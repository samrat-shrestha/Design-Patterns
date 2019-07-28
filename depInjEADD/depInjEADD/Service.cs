using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depInjEADD
{
    public interface IService
    {
        void Serve();
    }
    public class Service1 : IService
    {
        public void Serve() { Console.WriteLine("Service1 Called"); }
    }
    public class Service2 : IService
    {
        public void Serve() { Console.WriteLine("Service2 Called"); }
    }
}
