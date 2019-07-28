using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absFactEADD
{
    class IndianCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new Kheer();
        }

        public override MainCourse CreateMain()
        {
            return new Biryani();
        }
    }
}
