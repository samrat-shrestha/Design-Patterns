using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absFactEADD
{
    //For Chinese.
    class Cake : Dessert
    {
        public override string dessDef()
        {
            return ("Sticky Rice Cakes");
        }
    }

    //Similar for the indian recipes.
    class Kheer : Dessert
    {
        public override string dessDef()
        {
            return ("Kheer"); 
        }
    }
}
