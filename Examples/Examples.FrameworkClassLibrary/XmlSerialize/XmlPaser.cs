using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Examples.FrameworkClassLibrary.XmlSerialize
{
    public class XmlPaser
    {
        public static void Demo()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"\TestData\Person.xml";
            var person = new XmlPaser().Deserialize<Person>(path);
            var person1 = new XmlPaser().Deserialize2<Person>(path);

        }
        public T Deserialize<T>(string path) where T : class, new()
        {
            var xml = File.ReadAllText(path);
           xml= xml.Replace("<name>", "<name><![CDATA[");
           xml= xml.Replace("</name>", "]]></name>");
            using (var reader = new StringReader(xml))
            {

                var serialize = new XmlSerializer(typeof(T));
                return (T)serialize.Deserialize(reader);
            }

            return new T();
        }

        public T Deserialize2<T>(string path) where T : class, new()
        {
            using (var reader = new StreamReader(path))
            {
                var serialize = new XmlSerializer(typeof(T));
                return (T)serialize.Deserialize(reader);
            }

            return new T();
        }

        [Serializable]
        [XmlRoot("Person")]
        public class Person
        {
            private string name = "";
            [XmlElement("name")]
            public string Name { get; set; }
           

            [XmlElement("age")]
            public int Age { get; set; }
        }
    }
}
