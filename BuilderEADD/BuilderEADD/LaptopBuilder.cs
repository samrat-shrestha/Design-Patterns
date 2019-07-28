using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEADD
{
    class LaptopBuilder
    {
        public void BuildLaptop(ILaptopBuilder laptopBuilder)
        {
            laptopBuilder.addModelNumber();
            laptopBuilder.addDisplay();
            laptopBuilder.addRAM();
            laptopBuilder.addGraphicsCard();
        }
    }
}
