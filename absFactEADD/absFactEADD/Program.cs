using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absFactEADD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To TheBluess");
            Console.WriteLine("What Do You Want To Have?\n1.Chinese\n2.Indian");
            int input = Convert.ToInt32(Console.ReadLine());
            RecipeFactory factory;

            switch (input)
            {
                case 1:
                    factory = new ChineseCuisineFactory();
                    Console.WriteLine("\nMain Course: " + factory.CreateMain().courseDef());
                    Console.WriteLine("Dessert: " + factory.CreateDessert().dessDef());
                    break;

                case 2:
                    factory = new IndianCuisineFactory();
                    Console.WriteLine("\nMain Course: " + factory.CreateMain().courseDef());
                    Console.WriteLine("Dessert: " + factory.CreateDessert().dessDef());
                    break;

                default:
                    Console.WriteLine("Invalid Input!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
