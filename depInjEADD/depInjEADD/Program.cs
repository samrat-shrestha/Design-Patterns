using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depInjEADD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor Injection.
            Service1 s1 = new Service1();
            //passing dependency
            Client1 c1 = new Client1(s1);
            //TO DO:
            c1.ServeMethod();

            Service2 s2 = new Service2();
            //passing dependency
            //New object creation is emphasized.
            c1 = new Client1(s2);
            //TO DO:
            c1.ServeMethod();

            //Property Injection.
            Service1 s3 = new Service1();

            Client2 c2 = new Client2();
            c2.Service = s3; //passing dependency
            //TO DO:
            c2.ServeMethod();

            Service2 s4 = new Service2();
            c2.Service = s4; //passing dependency
            //No need for new object creation.
            //TO DO:
            c2.ServeMethod();

            //Method Injection.
            //creating object
            Service1 s5 = new Service1();

            Client3 client = new Client3();
            client.Start(s5); //passing dependency
                            
            Service2 s6 = new Service2();
            client.Start(s6); //passing dependency
            Console.ReadLine();
        }
    }
}
