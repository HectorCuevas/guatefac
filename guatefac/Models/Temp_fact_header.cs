using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace guatefac.Models
{
	[XmlRoot(ElementName = "temp_fact_header")]
	public class Temp_fact_header
	{


		[XmlElement(ElementName = "grantotal")]
		public string Grantotal { get; set; }
		[XmlElement(ElementName = "codigomoneda")]
		public string Codigomoneda { get; set; }
		[XmlElement(ElementName = "fechahoraemision")]
		public string Fechahoraemision { get; set; }
		[XmlElement(ElementName = "fechavencimiento")]
		public string Fechavencimiento { get; set; }
		[XmlElement(ElementName = "identificadorunico")]
		public string Identificadorunico { get; set; }
		[XmlElement(ElementName = "numeroaccesso")]
		public string Numeroaccesso { get; set; }
		[XmlElement(ElementName = "afiliacioniva")]
		public string Afiliacioniva { get; set; }
		[XmlElement(ElementName = "codigoestablecimiento")]
		public string Codigoestablecimiento { get; set; }
		[XmlElement(ElementName = "nitemisor")]
		public string Nitemisor { get; set; }
		[XmlElement(ElementName = "nombreemisor")]
		public string Nombreemisor { get; set; }
		[XmlElement(ElementName = "correoemisor")]
		public string Correoemisor { get; set; }
		[XmlElement(ElementName = "direccionemisor")]
		public string Direccionemisor { get; set; }
		[XmlElement(ElementName = "codigopostalemisor")]
		public string Codigopostalemisor { get; set; }
		[XmlElement(ElementName = "paisemisor")]
		public string Paisemisor { get; set; }
		[XmlElement(ElementName = "departamentoemisor")]
		public string Departamentoemisor { get; set; }
		[XmlElement(ElementName = "municipioemisor")]
		public string Municipioemisor { get; set; }
		[XmlElement(ElementName = "nombrecomercial")]
		public string Nombrecomercial { get; set; }
		[XmlElement(ElementName = "correoreceptor")]
		public string Correoreceptor { get; set; }
		[XmlElement(ElementName = "idreceptor")]
		public string Idreceptor { get; set; }
		[XmlElement(ElementName = "nombrereceptor")]
		public string Nombrereceptor { get; set; }
		[XmlElement(ElementName = "direccionreceptor")]
		public string Direccionreceptor { get; set; }
		[XmlElement(ElementName = "codigopostalreceptor")]
		public string Codigopostalreceptor { get; set; }
		[XmlElement(ElementName = "paisreceptor")]
		public string Paisreceptor { get; set; }
		[XmlElement(ElementName = "departamentoreceptor")]
		public string Departamentoreceptor { get; set; }
		[XmlElement(ElementName = "municipioreceptor")]
		public string Municipioreceptor { get; set; }
		[XmlElement(ElementName = "exenta")]
		public string Exenta { get; set; }
		[XmlElement(ElementName = "tipo")]
		public string Tipo { get; set; }
		[XmlElement(ElementName = "exportacion")]
		public string Exportacion { get; set; }
		[XmlElement(ElementName = "vendedor")]
		public string Vendedor { get; set; }
		[XmlElement(ElementName = "condicionpago")]
		public string Condicionpago { get; set; }
		[XmlElement(ElementName = "transporte")]
		public string Transporte { get; set; }
		[XmlElement(ElementName = "tipoventa")]
		public string TipoVenta { get; set; }
		[XmlElement(ElementName = "destinoventa")]
		public string DestinoVenta { get; set; }
		[XmlElement(ElementName = "moneda")]
		public string Moneda { get; set; }
		[XmlElement(ElementName = "tasa")]
		public string Tasa { get; set; }
		[XmlElement(ElementName = "bruto")]
		public string Bruto { get; set; }
		[XmlElement(ElementName = "descuento")]
		public string Descuento { get; set; }
		[XmlElement(ElementName = "exento")]
		public string Exento { get; set; }
		[XmlElement(ElementName = "neto")]
		public string Neto { get; set; }
		[XmlElement(ElementName = "iva")]
		public string Iva { get; set; }
		[XmlElement(ElementName = "total")]
		public string Total { get; set; }
		[XmlElement(ElementName = "isr")]
		public string Isr { get; set; }
		[XmlElement(ElementName = "daserie")]
		public string DASerie { get; set; }
		[XmlElement(ElementName = "dapreimpreso")]
		public string DAPreimpreso { get; set; }



	}
	
}