using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Bookstore
{
    [XmlType("book")]
    public class Book
    {
        [XmlAttribute("category")]
        public string Category { get; set; }

        [XmlAttribute("cover")]
        public string Cover { get; set; }

        [XmlElement("title")]
        public Title Title { get; set; }

        [XmlElement("author")]
        public List<string> Authors { get; set; }

        [XmlElement("year")]
        public int Year { get; set; }

        [XmlElement("price")]
        public double Price { get; set; }

        public Book(string Category, string Cover, Title Title, List<string> Authors, int Year, double Price)
        {
            this.Category = Category;
            this.Cover = Cover;
            this.Title = Title;
            this.Authors = Authors;
            this.Year = Year;
            this.Price = Price;
        }

        public Book()
        {

        }
    }
}
