using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CheckRegisteredCultures
{
    class XMLparser
    {
        public List<string> Cultures = new List<string>();
        public XMLparser(string countryXmlPath)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(countryXmlPath);
            XmlNodeList countries=  xmlDoc.SelectNodes("//country");

            for (int i = 0; i < countries.Count; i++)
            {
                var attr = countries[i].Attributes;
                if (attr["group"]==null)
                {
                    Cultures.Add(attr["lang"].Value);
                }
            }
        }
    }
}
