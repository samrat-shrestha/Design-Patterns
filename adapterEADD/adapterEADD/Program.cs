using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterEADD
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlConverter = new XMLFormat();
            var adapter = new XMLtoJSON(xmlConverter);
            adapter.ConvertXmlToJson();
            Console.ReadKey();
        }
    }
}
