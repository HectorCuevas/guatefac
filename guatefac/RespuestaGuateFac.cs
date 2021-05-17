using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace guatefac
{
	[XmlRoot(ElementName = "Resultado")]
	public class RespuestaGuateFac
    {
		[XmlElement(ElementName = "Serie")]
		public string Serie { get; set; }
		[XmlElement(ElementName = "Preimpreso")]
		public string Preimpreso { get; set; }
		[XmlElement(ElementName = "Nombre")]
		public string Nombre { get; set; }
		[XmlElement(ElementName = "Direccion")]
		public string Direccion { get; set; }
		[XmlElement(ElementName = "Telefono")]
		public string Telefono { get; set; }
		[XmlElement(ElementName = "NumeroAutorizacion")]
		public string NumeroAutorizacion { get; set; }
		[XmlElement(ElementName = "Referencia")]
		public string Referencia { get; set; }
	}
}