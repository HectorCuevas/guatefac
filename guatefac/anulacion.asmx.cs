using guatefac.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace guatefac
{
    /// <summary>
    /// Summary description for anulacion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class anulacion : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet anular(string xml)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            com.guatefacturas.dte.Guatefac guatefac = new com.guatefacturas.dte.Guatefac();
            guatefac.Credentials = new NetworkCredential(Configuracion.auth_user, Configuracion.auth_password);
            guatefac.PreAuthenticate = true;
            VFPData_an anular = DeserializeDetail<VFPData_an>(xml);
            string nit = Configuracion.nit;
            DateTime oDate = DateTime.Parse(anular.Temp_fact_detail.Pfechaanulacion);
            string date = formatDate(oDate);
            string res = guatefac.anulaDocumento(
                Configuracion.usuario,
                Configuracion.password,
                nit,
                anular.Temp_fact_detail.Pserie,
                anular.Temp_fact_detail.Ppreimpreso, 
                anular.Temp_fact_detail.Pnitcomprador,
                //anular.Temp_fact_detail.Pfechaanulacion,
                date,
                anular.Temp_fact_detail.Pmotivoanulacion
                );

            return generateDS(evaluateResponse(res));
        }

        public VFPData_an DeserializeDetail<VFPData_an>(string enc)
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(VFPData_an));
            using (StringReader sr = new StringReader(enc))
            {
                 return (VFPData_an)ser.Deserialize(sr);
            }
        }
        private DataSet generateDS(RespuestaServicio respuestaServicio)
        {
            DataSet DSdetalle = new DataSet();
            DataTable dt = new DataTable("resultado");
            dt.Columns.Add(new DataColumn("resultado", typeof(string)));
            dt.Columns.Add(new DataColumn("mensaje", typeof(string)));
            DataRow dr = dt.NewRow();
            dr["resultado"] = respuestaServicio.resultado;//.resultado;
            dr["mensaje"] = respuestaServicio.mensaje;//.mensaje;
            dt.Rows.Add(dr);
            DSdetalle.Tables.Add(dt);
            
            return DSdetalle;
        }


        RespuestaServicio evaluateResponse(string s)
        {
            RespuestaServicio respuestaGuate = new RespuestaServicio();
            string resultado = "";
            var matches = Regex.Matches(s, @"<ESTADO>(.*)<\/ESTADO>", RegexOptions.Singleline)
                  .Cast<Match>()
                    .Select(m => m.Value)
                    .ToArray();

            if (matches.Length > 0)
            {
                resultado = matches[0];
                // getInfo(resultado);
                GTDocumento gTDocumento = null;// DeserializeDate<GTDocumento>(resultado);
                respuestaGuate.resultado = true;
                respuestaGuate.mensaje = matches[0];
            }
            else
            {
                respuestaGuate.resultado = false;
                respuestaGuate.mensaje = s;
                if (respuestaGuate.mensaje == null)
                {
                    respuestaGuate.mensaje = s;
                }
            }
            return respuestaGuate;
        }

        public static String formatDate(DateTime oDate)
        {
            String mes = "", dia = "", newDate = "";
            if (oDate.Month <= 9)
            {
                mes = "0" + oDate.Month.ToString();
            }
            else
            {
                mes = oDate.Month.ToString();
            }
            if (oDate.Day <= 9)
            {
                dia = "0" + oDate.Day.ToString();
            }
            else
            {
                dia = oDate.Day.ToString();
            }
            newDate = oDate.Year + mes + dia;
            return newDate;
        }
    }
}
