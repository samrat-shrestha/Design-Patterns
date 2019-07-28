using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryEADD
{
    enum ClubName
    {
        Chelsea,
        Tottenham,
        Arsenal
    }

    interface SeasonInfo
    {
        void Overall();
        void CurrentSeason();
    }

    class Chelsea : SeasonInfo
    {
        public void Overall()
        {
            Console.WriteLine("League Titles : 6\nF.A Cups : 8\nEuropa League: 2\nChampions League: 1");
        }

        public void CurrentSeason()
        {
            Console.WriteLine("League Position : 3\nTrophies Won:\nEuropa League");
        }
    }

    class Tottenham : SeasonInfo
    {
        public void Overall()
        {
            Console.WriteLine("League Titles : 2\nF.A Cups : 8\nEuropa League: 0\nChampions League: 0");
        }

        public void CurrentSeason()
        {
            Console.WriteLine("League Position : 4\nTrophies Won:\nNone");
        }
    }

    class Arsenal : SeasonInfo
    {

        public void Overall()
        {
            Console.WriteLine("League Titles : 13\nF.A Cups : 13\nEuropa League: 0\nChampions League: 0");
        }

        public void CurrentSeason()
        {
            Console.WriteLine("League Position : 5\nTrophies Won:\nNone");
        }
    }

    interface ClubFactory
    {
        SeasonInfo Details(ClubName type);
    }

    class ClubDetails : ClubFactory
    {
        public SeasonInfo Details(ClubName type)
        {
            switch (type)
            {
                case ClubName.Chelsea:
                    return new Chelsea();
                case ClubName.Tottenham:
                    return new Tottenham();
                case ClubName.Arsenal:
                    return new Arsenal();
                default:
                    return new Chelsea();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputVal;
            string inputSeason;
            ClubFactory club = new ClubDetails();
            Console.WriteLine("Which Club Info You Need:\n1.Chelsea\n2.Tottenham\n3.Arsenal");
            inputVal = Console.ReadLine();

            switch (inputVal)
            {
                case "1":
                    Console.WriteLine("1.Overall\n2.Current Season");
                    inputSeason = Console.ReadLine();
                    SeasonInfo cinfo = club.Details(ClubName.Chelsea);
                    if (inputSeason == "1")
                    {
                        // Use created object
                        cinfo.Overall();
                    }

                    else
                    {
                        cinfo.CurrentSeason();
                    }
                    break;

                case "2":
                    Console.WriteLine("1.Overall\n2.Current Season");
                    inputSeason = Console.ReadLine();
                    SeasonInfo tinfo = club.Details(ClubName.Tottenham);
                    if (inputSeason == "1")
                    {
                        // Use created object
                        tinfo.Overall();
                    }

                    else
                    {
                        tinfo.CurrentSeason();
                    }
                    break;

                case "3":
                    Console.WriteLine("1.Overall\n2.Current Season");
                    inputSeason = Console.ReadLine();
                    SeasonInfo ainfo = club.Details(ClubName.Arsenal);
                    if (inputSeason == "1")
                    {
                        // Use created object
                        ainfo.Overall();
                    }

                    else
                    {
                        ainfo.CurrentSeason();
                    }
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
