using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEADD
{
    class NormalLaptop:ILaptopBuilder
    {

        Laptop laptop = new Laptop();
        public void addModelNumber()
        {
            laptop.ModelNumber = "ASUS ZenBook UX410UA";
        }
        public void addDisplay()
        {
            laptop.Display = "SD Display";
        }
        public void addRAM()
        {
            laptop.RAM = "8 GB";
        }
        public void addGraphicsCard()
        {
            laptop.GraphicsCard = "No graphics card";
        }
        public Laptop getLaptop()
        {
            return laptop;
        }
    }
}
