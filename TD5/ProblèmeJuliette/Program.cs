using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblèmeJuliette
{
    class Program
    {
        public static int[] AffichageAléatoire()
        {
            Random random = new Random();
            int[] compteur = new int[9]; // la case du tableau prend la valeur 1 si le numéro est sorti
            int[] affichage_aleat = new int[9];
            int numero = random.Next(1, 10);

            for (int i = 0; i < affichage_aleat.Length ; i++)
            {
                while (compteur[numero - 1] != 0)
                {
                    Console.WriteLine($"compteur = {compteur[numero - 1]}, numero = {numero}");
                    numero = random.Next(1, 10);
                }

                affichage_aleat[i] = numero;
                compteur[numero - 1]++;
                numero = random.Next(1, 10);

            }
            return affichage_aleat;
        }

        public static void bonjour(out int wesh)
        {
            wesh = 2;
        }

        public static int salut( int a, int b)
        {
            return a + b;
        }
        
        public static void prout(int[] tab)
        {
            tab[0] = 666;
            tab[1] = 69;
        }
        static void Main(string[] args)
        {
            /*int[] affichage = AffichageAléatoire();
            for (int i = 0; i < 9; i++)
            { Console.WriteLine(affichage[i]); }*/

            /*int a =(int) Math.Pow(2, 8);
            bonjour(out a);*/

            //Console.WriteLine(true & true);

            /*int i = 0;
            while(i < 1000)
            {
                Console.Write("-");
                Console.Write("\r");
                Console.Write("\\");
                Console.Write("\r");
                Console.Write("|");
                Console.Write("\r");
                Console.Write("/");
                Console.Write("\r");
            }*/

            int[] tab = new int[] { 1, 2 };

            prout(tab);
            Console.WriteLine(tab[0]);
            Console.WriteLine(tab[1]);
            Console.ReadKey();

        }
    }
}
