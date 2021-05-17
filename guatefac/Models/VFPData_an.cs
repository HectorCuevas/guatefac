using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace guatefac.Models
{
	[XmlRoot(ElementName = "VFPData")]
	public class VFPData_an
	{
		[XmlElement(ElementName = "temp_fact_detail")]
		public Temp_fact_detail_an Temp_fact_detail { get; set; }
	}
}