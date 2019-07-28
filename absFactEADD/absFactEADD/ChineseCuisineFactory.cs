using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absFactEADD
{
    //Concrete factory which is implementing the abstract factory.
    class ChineseCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new Cake();
        }

        public override MainCourse CreateMain()
        {
            return new Dumplings();
        }
    }
}
