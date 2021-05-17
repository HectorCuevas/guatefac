using guatefac.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;

namespace guatefac
{
    /// <summary>
    /// Summary description for facturacion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class facturacion : System.Web.Services.WebService
    {

        private DataSet DSencabezado = new DataSet();
        String TIPODOC = "";
        string FACT_NUM = "";
        [WebMethod]
         public DataSet factura(string encabezado, string detalle, string tipoDoc, string fact_num,string est)
        {
            RespuestaServicio respuesta = new RespuestaServicio();
            string xml = "";
            FACT_NUM = fact_num;
            TIPODOC = tipoDoc;
            Configuracion.DOC = tipoDoc;
            VFPData data =  Deserialize<VFPData>(encabezado);
            VFPDataDet dataDet = DeserializeDetail<VFPDataDet>(detalle);
            xml = XML.setXML(data, dataDet, tipoDoc);
            saveXML(xml, fact_num, Configuracion.path);
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            com.guatefacturas.dte.Guatefac guatefac = new com.guatefacturas.dte.Guatefac();
            guatefac.Credentials = new NetworkCredential(Configuracion.auth_user, Configuracion.auth_password);
            guatefac.PreAuthenticate = true;
            
            int pTipoDoc = setTipoDoc(tipoDoc);
            string s = guatefac
                .generaDocumento(
                Configuracion.usuario,
                Configuracion.password,
                Configuracion.nit,
                Int32.Parse(est),
                pTipoDoc,
                Configuracion.maquina, "D", xml);
            return generateDS(evaluateResponse(s));
        }
            
        public VFPData Deserialize<VFPData>(string enc) 
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(VFPData));
            using (StringReader sr = new StringReader(enc))
            {
                return (VFPData)ser.Deserialize(sr);
            }
        }

        public VFPDataDet DeserializeDetail<VFPDataDet>(string enc)
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(VFPDataDet));
            using (StringReader sr = new StringReader(enc))
            {
                return (VFPDataDet)ser.Deserialize(sr);
            }
        }

        public Resultado DeserializeResponse<Resultado>(string enc)
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(Resultado));
            using (StringReader sr = new StringReader(enc))
            {
                return (Resultado)ser.Deserialize(sr);
            }
        }
        
        public GTDocumento DeserializeDate<GTDocumento>(string enc)
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(GTDocumento));
            using (StringReader sr = new StringReader(enc))
            {
                return (GTDocumento)ser.Deserialize(sr);
            }
        }

        private void saveXML(string xml, string factnum, string ruta)
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.LoadXml(xml);
            String path = ruta;
            using (XmlTextWriter writer = new XmlTextWriter(path + factnum +".xml", null))
            {
                writer.Formatting = System.Xml.Formatting.Indented;
                doc.Save(writer);
            }
        }

        RespuestaServicio getInfo(string xml)
        {
            string pattern = @"<dte:FechaHoraCertificacion>(.*)<\/dte:FechaHoraCertificacion>";
            RespuestaServicio respuesta = new RespuestaServicio();
            string[] matches =  checkRegex(xml, pattern);

            if(matches.Length > 0)
            {
               // FechaHora fechaHora = DeserializeDate<FechaHora>(matches[0]);
            }

            respuesta.resultado = true;
            respuesta.XML = xml;
            string fecha = matches[0];

            return respuesta;
        }


        private string[] checkRegex(string value, string pattern)
        {
            return  Regex.Matches(value, pattern, RegexOptions.Singleline)
                 .Cast<Match>()
                   .Select(m => m.Value)
                   .ToArray();

        }
        private DataSet generateDS(RespuestaServicio respuestaServicio)
        {
            DataSet DSdetalle = new DataSet();
            DataTable dt = new DataTable("resultado");
            dt.Columns.Add(new DataColumn("resultado", typeof(string)));
            dt.Columns.Add(new DataColumn("mensaje", typeof(string)));
            dt.Columns.Add(new DataColumn("xml", typeof(string)));
            dt.Columns.Add(new DataColumn("uuui", typeof(string)));
            dt.Columns.Add(new DataColumn("fecha", typeof(string)));
            DataRow dr = dt.NewRow();
            dr["resultado"] = respuestaServicio.resultado;
            dr["mensaje"] = respuestaServicio.mensaje;
            dr["xml"] = respuestaServicio.XML;
            dr["uuui"] = respuestaServicio.UUUI;
            dr["fecha"] = respuestaServicio.fecha;
            dt.Rows.Add(dr);
            DSdetalle.Tables.Add(dt);

            saveXML(respuestaServicio.XML, TIPODOC + FACT_NUM, Configuracion.pathRes);

            return DSdetalle;
        }

        RespuestaServicio evaluateResponse(string s)
        {
            RespuestaServicio respuestaGuate = new RespuestaServicio();
            Resultado serialize;
            string resultado = "";
            var matches = Regex.Matches(s, @"<dte:GTDocumento (.*)<\/dte:GTDocumento>", RegexOptions.Singleline)
                  .Cast<Match>()
                    .Select(m => m.Value)
                    .ToArray();

            if(matches.Length > 0)
            {                
                resultado = matches[0];
                // getInfo(resultado);
                GTDocumento gTDocumento = DeserializeDate<GTDocumento>(resultado);
                respuestaGuate.resultado = true;
                respuestaGuate.mensaje = "Sin errores";
                respuestaGuate.XML = resultado;
                respuestaGuate.UUUI = gTDocumento.SAT.DTE.Certificacion.NumeroAutorizacion.Text;
                respuestaGuate.fecha = gTDocumento.SAT.DTE.Certificacion.FechaHoraCertificacion;
            }
            else
            {
                
            ///    serialize = DeserializeResponse<Resultado>(s);
                respuestaGuate.resultado = false;
                respuestaGuate.mensaje = s;
                if (respuestaGuate.mensaje==null)
                {
                    respuestaGuate.mensaje = s;
                }     
            }
            return respuestaGuate;
        }



        private int setTipoDoc(string tipo)
        {
            switch (tipo)
            {
                case "FACT":
                    return 1;
                case "FCAM":
                    return 2;
                case "NCRE":
                    return 10;
                case "NABN":
                    return 6;
                default:
                    return 1;
            }
        }
       

    }
}
