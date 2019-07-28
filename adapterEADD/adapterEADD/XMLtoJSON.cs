using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterEADD
{
    //This is the adapter to convert XML to Json.
    public interface IXmlToJson
    {
        void ConvertXmlToJson();
    }
    public class XMLtoJSON : IXmlToJson
    {
        private readonly XMLFormat _xmlFormat;

        //The data of the XML is fed to private readonly variable from here.
        public XMLtoJSON(XMLFormat xmlFormat)
        {
            _xmlFormat = xmlFormat;
        }
        public void ConvertXmlToJson()
        {
            //Filling the Songs. 
            var songs = _xmlFormat.GetXML()
                .Element("Songs")
                .Elements("Songs")
                .Select(m => new Songs
                {
                    ID = Convert.ToInt32(m.Attribute("ID").Value),
                    Name = m.Attribute("Name").Value,
                    SHA1 = m.Attribute("SHA1").Value
                });

            new JSONConverter(songs)
                .ConvertToJson();
        }
    }
}
