using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo12
{
    class Program
    {public static double inverse(double x, double a)
        {
            double y = x * x + a;
            if (y != 0)
            {
                return 1 / y;
            }
            else
            {
                return 0;
            }
        }

        public static bool detection(double[] centre, double r, double[] m)
        {
            double x_c = centre[0];
            double y_c = centre[1];
            double x_m = m[0];
            double y_m = m[1];

            double x = x_m - x_c;
            double y = y_m - y_c;
            double[] v = new double[] { x, y };

            if (norm(v) <= r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double norm(double[] vector)
        {
            return Math.Sqrt(Math.Pow(vector[0], 2.0)+ Math.Pow(vector[1], 2.0));
        }

        public static bool colineaire(double[] a, double[] b)
        {
            
            if(a[0]* b[1] == a[1] * b[0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            double r = 10;
            double[] centre = new double[] { 1, 1 };
            double[] m = new double[] { 10, 3 };

            Console.WriteLine(detection(centre, r, m));

            double[] a = new double[] { 1, 1 };
            double[] b = new double[] { 2, 2 };
            double[] c = new double[] { 3, 3 };

            bool verif = false;
            if(colineaire(a,b) & colineaire(a,c) & colineaire(b,c))
            {
                verif = true;
            }

            Console.WriteLine($"les points sont alignés = {verif}");
            Console.ReadKey();
            
        }
    }
}
