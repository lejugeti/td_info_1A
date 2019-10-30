using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void placement(int kilometre)
        {
            int[] km = new int[] { 0, 10, 24, 35, 54, 71, 93, 124 };
            string[] ville = new string[] {"bordeaux", "labrède", "podensac", "langon", "la réole",
                "marmande", "aiguillon", "agen"};

            bool done = false;
            int marqueur = 0;

            for (int i = 0; i < km.Length; i++)
            {

                if (kilometre == km[i])
                {
                    Console.WriteLine($"on se trouve à la sortie de {ville[i]}");
                    done = true;
                    break;
                }
                else if (kilometre > km[km.Length - 1])
                {
                    Console.WriteLine("On est au delà du tronçon d'autoroute");
                    done = true;
                    break;
                }

                else if (kilometre > km[i])
                {
                    marqueur = i;
                }

                

                

            }

            if (done == false)
            {
                Console.WriteLine($"on se trouve à la entre {ville[marqueur]} et {ville[marqueur + 1]}");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            placement(2);
            placement(70);
            placement(24);
            placement(388);
        }
    }
}
