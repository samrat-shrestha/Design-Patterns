﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEADD
{
    interface ILaptopBuilder
    {
        void addModelNumber();
        void addDisplay();
        void addRAM();
        void addGraphicsCard();
        Laptop getLaptop();
    }
    class Laptop
    {
        public string ModelNumber { get; set; }
        public string Display { get; set; }
        public string RAM { get; set; }
        public string GraphicsCard { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine("----------- Laptop Details ----------------");
            Console.WriteLine("Model Number: {0}", ModelNumber);
            Console.WriteLine("Display: {0}", Display);
            Console.WriteLine("RAM: {0}", RAM);
            Console.WriteLine("Graphics Card: {0}", GraphicsCard);
        }
    }
}
