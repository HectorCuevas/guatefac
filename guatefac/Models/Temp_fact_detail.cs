using System.Xml.Serialization;

namespace guatefac.Models
{
	[XmlRoot(ElementName = "temp_fact_detail")]
	public class Temp_fact_detail
    {
		[XmlElement(ElementName = "producto")]
		public string Producto { get; set; }
		[XmlElement(ElementName = "descripcion")]
		public string Descripcion { get; set; }
		[XmlElement(ElementName = "medida")]
		public string Medida { get; set; }
		[XmlElement(ElementName = "cantidad")]
		public string Cantidad { get; set; }
		[XmlElement(ElementName = "precio")]
		public string Precio { get; set; }
		[XmlElement(ElementName = "porcdesc")]
		public string PorcDesc { get; set; }
		[XmlElement(ElementName = "impbruto")]
		public string ImpBruto { get; set; }
		[XmlElement(ElementName = "impdescuento")]
		public string ImpDescuento { get; set; }
		[XmlElement(ElementName = "impexento")]
		public string ImpExento { get; set; }
		[XmlElement(ElementName = "impotros")]
		public string ImpOtros { get; set; }
		[XmlElement(ElementName = "impneto")]
		public string ImpNeto { get; set; }
		[XmlElement(ElementName = "impiva")]
		public string ImpIva { get; set; }
		[XmlElement(ElementName = "impisr")]
		public string ImpIsr { get; set; }
		[XmlElement(ElementName = "imptotal")]
		public string ImpTotal { get; set; }
		[XmlElement(ElementName = "tipoventadet")]
		public string TipoVentaDet { get; set; }
	}
}