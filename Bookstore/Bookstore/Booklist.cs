using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Bookstore
{
    [XmlType("bookstore")]
    public class Booklist
    {
        [XmlElement(ElementName = "book")]
        public List<Book> Books { get; set; }

        public Booklist()
        {
            Books = new List<Book>();
        }

        public void AddBook(string category, string cover, string titleValue, string language,
            List<string> authors, int year, double price)
        {
            Title title = new Title(titleValue, language);
            Book book = new Book(category, cover, title, authors, year, price);
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
    }
}
