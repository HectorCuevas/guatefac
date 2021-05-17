using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace guatefac.Models
{
    [XmlRoot(ElementName = "VFPData")]
    public class VFPDataDet
    {
        [XmlElement(ElementName = "temp_fact_detail")]
        public List<Temp_fact_detail> Temp_fact_detail { get; set; }
    }
}