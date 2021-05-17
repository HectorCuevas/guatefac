using guatefac.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace guatefac
{
    public class XML
    {

        

        public static string setXML (VFPData data, VFPDataDet dataDet, string tipo)
        {
            XDeclaration declaracion = new XDeclaration("1.0", "utf-8", "no");

            //GTDocumento
            XElement xmlDoc = new XElement("DocElectronico");

            //Encabezado
            XElement encabezado = new XElement("Encabezado");
            xmlDoc.Add(encabezado);

            //Receptor
            XElement receptor = new XElement("Receptor");
            encabezado.Add(receptor);

            XElement NITReceptor = new XElement("NITReceptor", data.Temp_fact_header.Idreceptor);
            receptor.Add(NITReceptor);

            XElement nombre = new XElement("Nombre", data.Temp_fact_header.Nombrereceptor);
            receptor.Add(nombre);

            XElement direccion = new XElement("Direccion", data.Temp_fact_header.Direccionreceptor);
            receptor.Add(direccion);

            //InfoDoc
            XElement infoDoc = new XElement("InfoDoc");
            encabezado.Add(infoDoc);

            XElement tipoVenta = new XElement("TipoVenta", data.Temp_fact_header.TipoVenta);
            infoDoc.Add(tipoVenta);

            XElement destinoVenta = new XElement("DestinoVenta", data.Temp_fact_header.DestinoVenta);
            infoDoc.Add(destinoVenta);


            DateTime oDate = DateTime.Parse(data.Temp_fact_header.Fechahoraemision);
            
            XElement Fecha = new XElement("Fecha", formatDate(oDate));
            //XElement Fecha = new XElement("Fecha", data.Temp_fact_header.Fechavencimiento);
            infoDoc.Add(Fecha);

            XElement moneda = new XElement("Moneda", data.Temp_fact_header.Moneda);
            infoDoc.Add(moneda);

            XElement tasa = new XElement("Tasa", data.Temp_fact_header.Tasa);
            infoDoc.Add(tasa);

            XElement referencia = new XElement("Referencia", data.Temp_fact_header.Identificadorunico);
            infoDoc.Add(referencia);

            XElement numeroAcceso = new XElement("NumeroAcceso", data.Temp_fact_header.Numeroaccesso);
            infoDoc.Add(numeroAcceso);

            XElement serieAdmin = new XElement("SerieAdmin");
            infoDoc.Add(serieAdmin);

            XElement numeroAdmin = new XElement("NumeroAdmin");
            infoDoc.Add(numeroAdmin);

            XElement reversion = new XElement("Reversion", "N");
            infoDoc.Add(reversion);



            //Totales
            XElement totales = new XElement("Totales");
            encabezado.Add(totales);

            //falta
            XElement bruto = new XElement("Bruto", data.Temp_fact_header.Bruto);
            totales.Add(bruto);

            //falta
            XElement descuento = new XElement("Descuento", data.Temp_fact_header.Descuento);
            totales.Add(descuento);

            //falta
            XElement exento = new XElement("Exento", 0);
            totales.Add(exento);

            XElement otros = new XElement("Otros", 0);
            totales.Add(otros);

            //falta
            //22.32 data.Temp_fact_header.Grantotal
            XElement neto = new XElement("Neto", data.Temp_fact_header.Neto);
            totales.Add(neto);

            XElement isr = new XElement("Isr", data.Temp_fact_header.Isr);
            totales.Add(isr);

            //falta
            XElement iva = new XElement("Iva", data.Temp_fact_header.Iva);
            totales.Add(iva);

            //falta
            XElement total = new XElement("Total", data.Temp_fact_header.Total);
            totales.Add(total);

            /********************************************************************************/

            //Detalles
            XElement detalles = new XElement("Detalles");
            xmlDoc.Add(detalles);

            foreach(Temp_fact_detail det in dataDet.Temp_fact_detail)
            {
                //Productos
                XElement productos = new XElement("Productos");
                XElement producto = new XElement("Producto", det.Producto);
                productos.Add(producto);

                XElement descripcion = new XElement("Descripcion", det.Descripcion);
                productos.Add(descripcion);

                XElement medida = new XElement("Medida", det.Medida);
                productos.Add(medida);

                XElement cantidad = new XElement("Cantidad", det.Cantidad);
                productos.Add(cantidad);

                XElement precio = new XElement("Precio", det.Precio);
                productos.Add(precio);

                XElement porDesc = new XElement("PorcDesc", det.PorcDesc);
                productos.Add(porDesc);

                XElement impBruto = new XElement("ImpBruto", det.ImpBruto);
                productos.Add(impBruto);

                XElement impDescuento = new XElement("ImpDescuento", det.ImpDescuento);
                productos.Add(impDescuento);

                int esExento = 0;
                if(data.Temp_fact_header.Exento == "SI")
                {
                    esExento = 1;
                }
                XElement impExento = new XElement("ImpExento", esExento);
                productos.Add(impExento);


                XElement impOtros = new XElement("ImpOtros", det.ImpOtros);
                productos.Add(impOtros);

                XElement impNeto = new XElement("ImpNeto", det.ImpNeto);
                productos.Add(impNeto);

                XElement impIsr = new XElement("ImpIsr", det.ImpIsr);
                productos.Add(impIsr);

                XElement impIva = new XElement("ImpIva", det.ImpIva);
                productos.Add(impIva);

                XElement impTotal = new XElement("ImpTotal", det.ImpTotal);
                productos.Add(impTotal);

                XElement tipoVentaDet = new XElement("TipoVentaDet", det.TipoVentaDet);
                productos.Add(tipoVentaDet);

                detalles.Add(productos);
            }

            /********************************************************************************/

            if (tipo.Equals("NCRE"))
            {
                XElement docAsociados = new XElement("DocAsociados");
                xmlDoc.Add(docAsociados);

                XElement daSerie = new XElement("DASerie", data.Temp_fact_header.DASerie);
                docAsociados.Add(daSerie);

                XElement daImpreso = new XElement("DAPreimpreso", data.Temp_fact_header.DAPreimpreso);
                docAsociados.Add(daImpreso);
            }

            XDocument myXML = new XDocument(declaracion, xmlDoc);
            return myXML.ToString();

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
            newDate = dia + "-" + mes + "-" + oDate.Year;
            return newDate;
        }
    }

}
