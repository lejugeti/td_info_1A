using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4
{
    class Program
    {
        public static double somme(double nb1, double nb2, double nb3, double nb4, double nb5)
        {
            return nb1 + nb2 + nb3 + nb4 + nb5;
        }

        public static double saisie()
        {
            return Double.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.WriteLine(somme(saisie(), saisie(), saisie(), saisie(), saisie()));
            Console.ReadKey();
        }
    }
}
