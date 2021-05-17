using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace guatefac.Models
{
	[XmlRoot(ElementName = "VFPData")]
	public class VFPData
	{
		[XmlElement(ElementName = "temp_fact_header")]
		public Temp_fact_header Temp_fact_header { get; set; }
	}
}