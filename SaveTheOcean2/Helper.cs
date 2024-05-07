using SaveTheOcean2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SaveTheOcean2
{
    public class Helper
    {

        public static int Random(int x, int y)
        {
            Random random = new Random();
            return random.Next(x, y + 1);
        }

        public static bool InRange(int max, int min, int num)
        {
            return (num <= max) && (num >= min);
        }

        public static void CreatePersonaXml()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Persones");
            xmlDocument.AppendChild(root);
            root.InnerText = "";
            xmlDocument.Save("Persones.xml");
        }
        public static void AppendPerson(Persona person)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Persones.xml");
            XmlElement root = xmlDocument.DocumentElement;
            XmlElement personElement = xmlDocument.CreateElement("Persona");
            XmlElement nameElement = xmlDocument.CreateElement("Name");
            nameElement.InnerText = person.Name;
            XmlElement rolElement = xmlDocument.CreateElement("Rol");
            rolElement.InnerText = person.Rol;
            XmlElement xpElement = xmlDocument.CreateElement("Xp");
            xpElement.InnerText = person.Xp.ToString();
            personElement.AppendChild(nameElement);
            personElement.AppendChild(rolElement);
            personElement.AppendChild(xpElement);
            root.AppendChild(personElement);
            xmlDocument.Save("Persones.xml");
        }
    }

}
