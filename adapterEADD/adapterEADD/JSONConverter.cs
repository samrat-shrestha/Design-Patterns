using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace adapterEADD
{
    public class JSONConverter
    {
        //IEnumerable is an interface defining a single method GetEnumerator() that returns an IEnumerator interface
        private IEnumerable<Songs> _songs;

        public JSONConverter(IEnumerable<Songs> songs)
        {
            _songs = songs;
        }

        public void ConvertToJson()
        {
            var jsonSongs = JsonConvert.SerializeObject(_songs, Formatting.Indented);

            Console.WriteLine("\nJSON list of Songs\n");
            Console.WriteLine(jsonSongs);
        }
    }
}
