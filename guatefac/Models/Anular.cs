using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace guatefac.Models
{
	[XmlRoot(ElementName = "temp_fact_detail")]
	public class Temp_fact_detail_an
	{
		[XmlElement(ElementName = "pserie")]
		public string Pserie { get; set; }
		[XmlElement(ElementName = "ppreimpreso")]
		public string Ppreimpreso { get; set; }
		[XmlElement(ElementName = "pnitcomprador")]
		public string Pnitcomprador { get; set; }
		[XmlElement(ElementName = "pfechaanulacion")]
		public string Pfechaanulacion { get; set; }
		[XmlElement(ElementName = "pmotivoanulacion")]
		public string Pmotivoanulacion { get; set; }
	}

	
}