using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo8
{
    class Program
    { public static double determinant(double[] trinome)
        { double a = trinome[0];
            double b = trinome[1];
            double c = trinome[2];

            double delta = b * b - 4 * a * c;

            if (delta>0)
            { Console.WriteLine("2 racines réelles possibles"); }
            else if (delta<0)
            { Console.WriteLine("racines possibles mais irréelles"); }
            else
            { Console.WriteLine("1 racine réelle possible"); }

            return delta;

        }

     public static double[] racines(double[] trinome, double delta)
        {
            double a = trinome[0];
            double b = trinome[1];
            double c = trinome[2];

            double racine1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double racine2 = (-b - Math.Sqrt(delta)) / (2 * a);
            double[] deux_racines = new double[] { racine1, racine2 };

            return deux_racines;
        }


        static void Main(string[] args)
        {
            double[] tri = new double[] { 4, 4, 1 };
            double delta = determinant(tri);
            double[] res = racines(tri, delta);

            Console.WriteLine($"racine_1 = {res[0]} ,   racine_2 = {res[1]}");
            Console.ReadKey();
        }
    }
}
