using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace guatefac.Models
{
    [XmlRoot(ElementName = "Resultado")]
    public class Resultado
    {
       [XmlText]
      // [XmlAnyAttribute]
       //[XmlAnyElement]
       //[XmlType]
        public string resultado { get; set; }
    }
}