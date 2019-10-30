using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3
{
    class Program
    {
        public static void jeu()
        {
            Random rng = new Random();
            int score_1 = 0;
            int score_2 = 0;
            int tmp_1;
            int tmp_2;

            for(int tour = 1; tour < 11 & score_1 < 40 & score_2 < 40; tour++)
            {
                tmp_1 = rng.Next(1, 6);
                tmp_2 = rng.Next(1, 6);
                score_1 += tmp_1;
                score_2 += tmp_2;

                Console.WriteLine("====================");
                Console.WriteLine($"Tour n°{tour}");
                Console.WriteLine("====================");
                Console.WriteLine($"J1 lance et obtient {tmp_1}");
                Console.WriteLine($"Son score est de {score_1}");
                Console.WriteLine($"J2 lance et obtient {tmp_2}");
                Console.WriteLine($"Son score est de {score_2}");

            }

            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
            if (score_1 < score_2 )
            {
                Console.WriteLine($"J2 gagne avec un score de {score_2}");
            }
            else
            {
                Console.WriteLine($"J1 gagne avec un score de {score_1}");
            }
        }
        static void Main(string[] args)
        {
            jeu();
            Console.ReadKey();
        }
    }
}
