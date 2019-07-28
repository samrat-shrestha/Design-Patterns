using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterEADD
{
    public class SongDataProvider
    {
        public static List<Songs> GetData() =>
           new List<Songs>
           {
            new Songs { ID = 1 , Name = "Nokia", SHA1 = "09xxc12234" },
            new Songs { ID = 2,  Name = "Tequila", SHA1 = "00056xcvc3", },
            new Songs { ID = 3, Name = "Despacito", SHA1 = "056erdwc12" },
           };
    }
}
