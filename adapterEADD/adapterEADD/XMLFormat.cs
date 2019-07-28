using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace adapterEADD
{
    public class XMLFormat
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Songs");
            var xAttributes = SongDataProvider.GetData()
                .Select(m => new XElement("Songs",
                                    new XAttribute("ID", m.ID),
                                    new XAttribute("Name", m.Name),
                                    new XAttribute("SHA1", m.SHA1)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}
