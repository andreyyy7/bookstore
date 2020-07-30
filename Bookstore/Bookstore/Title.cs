using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Bookstore
{
    [XmlType("title")]
    public class Title
    {
        [XmlText]
        public string Value { get; set; }

        [XmlAttribute("lang")]
        public string Language { get; set; }

        public Title(string Value, string Language)
        {
            this.Value = Value;
            this.Language = Language;
        }

        public Title()
        {

        }
    }
}
