using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEADD
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object of manufacturer
            LaptopBuilder laptopBuilder = new LaptopBuilder();
            // build Gaming Laptop
            ILaptopBuilder gamingLaptopBuilder = new GamingLaptop();
            laptopBuilder.BuildLaptop(gamingLaptopBuilder);
            Laptop GamingLaptop = gamingLaptopBuilder.getLaptop();
            // print details
            Console.WriteLine("Gaming Laptop Object:");
            GamingLaptop.PrintDetails();

            // build normal laptop
            ILaptopBuilder normalLaptopBuilder = new NormalLaptop();
            laptopBuilder.BuildLaptop(normalLaptopBuilder);
            Laptop NormalLaptop = normalLaptopBuilder.getLaptop();
            // print details
            Console.WriteLine("\nNormal Laptop Object:");
            NormalLaptop.PrintDetails();

            Console.ReadLine();
        }
    }
}
