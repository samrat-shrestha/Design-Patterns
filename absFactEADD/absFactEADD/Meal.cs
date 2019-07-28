using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absFactEADD
{
    //Concrete products.
    //Implementation of actual objects
    class Dumplings : MainCourse
    {
        public override string courseDef()
        {
            return ("Pork Dumplings"); 
        }
    }

    class Biryani : MainCourse
    {
        public override string courseDef()
        {
            return ("Veg Biryani"); 
        }
    }
}
