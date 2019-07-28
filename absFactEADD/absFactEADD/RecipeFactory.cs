using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absFactEADD
{
    //Abstract classes representing generic recipes.
    abstract class MainCourse
    {
        public abstract string courseDef();
    }

    abstract class Dessert
    {
        public abstract string dessDef();
    }
    //This factory defines method to create the absract object.
    abstract class RecipeFactory
    {
        public abstract MainCourse CreateMain();
        public abstract Dessert CreateDessert();
    }
}
