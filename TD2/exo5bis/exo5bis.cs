using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5bis
{
    class Program
    {
        public static long fact(long x)
        {
            if (x == 0)
            {
                return 1;
            }

            else
            {
                return x * fact(x - 1);
            }
        }

        public static int somme(int n)
        {
            int s = 0;

            for(int i = n; i != 0; i = i-1)
            {
                s += i;
            }
            return s;
        }

        public static int puissance(int x, int n)
        {
            int pui = x;
            for(int i = 0; i < n-1; i += 1)
            {
                pui *= x;
            }
            return pui;
        }

        public static double[] insertion(double[] tab, int i, double valeur)
        {

            for(int indice = tab.Length - 1; indice > i; indice -= 1)
            {
                tab[indice] = tab[indice - 1];
            }
            tab[i] = valeur;
            return tab;
        }

        public static void racine(double aire)
        {
            double x = 4;
            for(int i = 0; i < 100; i += 1)
            {
                x = (x + aire / x) / 2;
            }
            Console.WriteLine($"Sqrt({aire}) = {Math.Sqrt(aire)}, notre programme renvoie {x}");
        }

        public static void exponentielle(double x)
        {
            double e = 1;
            for(int i = 1; i < 20; ++i)
            {
                e += Math.Pow(x, i) / fact((long) i);
                Console.WriteLine(e);
            }

            Console.WriteLine($"exp({x}) = {Math.Exp(x)}, notre fonction renvoie {e}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(somme(4));
            Console.WriteLine(puissance(2, 3));

            double[] t = new double[] { 1, 2, 3, 4, 5 };
            t = insertion(t, 2, 0);
            for(int i = 0; i < t.Length; i += 1)
            {
                Console.WriteLine(t[i]);
            }

            racine(1997);
            exponentielle(4);
            Console.ReadKey();
        }
    }
}
