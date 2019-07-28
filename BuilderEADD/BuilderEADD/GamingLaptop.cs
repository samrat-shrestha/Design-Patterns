using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEADD
{
    class GamingLaptop:ILaptopBuilder
    {
        Laptop laptop = new Laptop();
        public void addModelNumber()
        {
            laptop.ModelNumber = "Razer Blade 15";
        }
        public void addDisplay()
        {
            laptop.Display = "Full HD display";
        }
        public void addRAM()
        {
            laptop.RAM = "32 GB";
        }
        public void addGraphicsCard()
        {
            laptop.GraphicsCard = "Nvidia GTX 1080";
        }
        public Laptop getLaptop()
        {
            return laptop;
        }
    }
}
