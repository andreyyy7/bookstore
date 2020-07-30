using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Bookstore
{
    public class Serializer
    {
        // Десериализация - Получение объекта из XML файла
        public T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        // Сериализация - Получение XML файла из объекта
        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());
            using (MemoryStream ms = new MemoryStream())
            using (XmlTextWriter textWriter = new XmlTextWriter(ms, Encoding.UTF8))
            {
                textWriter.Formatting = Formatting.Indented;
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }
    }
}
