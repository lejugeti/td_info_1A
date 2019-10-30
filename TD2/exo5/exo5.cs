using System;

namespace exo5
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
            int somme = 0;
            while (n != 0)
            {
                somme += n;
                n -= 1;
            }

            return somme;
        }

        public static int puissance(int x, int n)
        {
            int i = 1;
            int pui = x;
            while (i != n)
            {
                pui = pui * x;
                i += 1;
            }

            return pui;
        }

        public static double[] insertion(double[] tab, int i, double valeur)
        {
            int indice = tab.Length - 1;
            while (indice > i)
            {
                tab[indice] = tab[indice - 1];
                indice -= 1;
            }

            tab[i] = valeur;
            
            return tab;
        }

        public static void racine(double aire)
        {
            int i = 0;
            double x = 2;
            while(i < 100)
            {
                x = (x + (aire / x)) / 2;
                i += 1;
            }

            Console.WriteLine($"Sqrt({aire}) = {Math.Sqrt(aire)}, notre méthode renvoie {x}");
            
        }

        public static void exponentielle(double x)
        {
            double e = 1;
            int i = 0;
            while (i < 20) 
            {
                e += Math.Pow(x, i) / fact(i);
                i += 1;
            }

            Console.WriteLine($"exp({x} = {Math.Exp(x)}, notre programme renvoie {e}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(somme(4));
            Console.WriteLine(puissance(2, 3));

            double[] t = new double[] { 1, 2, 3, 4, 5 };
            t = insertion(t, 0, 0);
            int compteur = 0;
            while(compteur < t.Length)
            {
                Console.WriteLine(t[compteur]);
                compteur += 1;
            }

            racine(1997);
            exponentielle(10);
            Console.ReadKey();
        }
    }
}
