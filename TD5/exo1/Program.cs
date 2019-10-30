using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_5
{
    class Program
    {
        public static void interets(double taux, double somme_init)
        {
            double new_somme = somme_init;

            for(int annee = 0; annee < 10; annee++)
            {
                if (new_somme < 1500)
                {
                    new_somme = new_somme + new_somme * taux / 100;
                }
            }

            Console.WriteLine($"Dans 10 ans vous aurez {new_somme} euros");
            
        }
        static void Main(string[] args)
        {
            interets(10, 1254);
            Console.ReadKey();
        }
    }
}
