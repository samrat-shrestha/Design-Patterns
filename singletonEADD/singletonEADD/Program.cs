using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletonEADD
{
    class Singleton
    {
        static int instanceCounter = 0;
        //To check whether the object has been created previously.
        private static Singleton singleInstance = null;

        /*public Singleton()
        {
            instanceCounter++;
            Console.WriteLine("Instances created " + instanceCounter);
        }*/
        private Singleton()
            {
                instanceCounter++;
                Console.WriteLine("Instances created " + instanceCounter);
            }

        //Static method for object creation.
        public static Singleton SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                    singleInstance = new Singleton();
                }
                return singleInstance;
            }
        }
        public void LogMessage(string message)
        {
            Console.WriteLine("Message " + message);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton fromManager = new Singleton();
            Singleton fromRuben = Singleton.SingleInstance;
            fromRuben.LogMessage("Request Message from Ruben");


            //Singleton fromEmployee = new Singleton();
            Singleton fromHudson = Singleton.SingleInstance;
            fromHudson.LogMessage("Request Message from Hudson-Odoi");

            Console.ReadLine();
        }
    }
}
