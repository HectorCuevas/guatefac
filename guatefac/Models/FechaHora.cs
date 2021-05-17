using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace guatefac.Models
{
    public class FechaHora
    {
        [XmlRoot(ElementName = "FechaHoraCertificacion")]
        public class FechaHoraCertificacion
        {
            [XmlText]
            public string Text { get; set; }
        }
    }
}