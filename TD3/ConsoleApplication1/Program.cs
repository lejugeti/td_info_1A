using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Program
    {
        public static void print(int[,] tab)
        {
            for(int ligne = 0; ligne < tab.GetLength(0); ligne++)
            {
                for(int col = 0; col < tab.GetLength(1); col++)
                {
                    Console.Write(tab[ligne, col]);
                }
                Console.WriteLine(" ");
            }
        }
        public static int retour(int x)
        {
            if(x >= 10)
            {
                return x - 10;
            }
            else
            {
                return x;
            }
        }

        public static void pyramide()
        {
            int h = 10;
            double largeur_max = h * 2 - 1;
            int borne = 1;
            int milieu = (int) Math.Round(largeur_max / 2);
            int[,] tab = new int[10, 19];

            //derniere ligne
            for(int col = 0; col < milieu; col++)
            {
                tab[9, col] = col;
                tab[9, (int)largeur_max - 1 - col] = col;
            }
           
            //reste tableau
            for(int ligne = h - 2; ligne >= 0; ligne--)
            {
                
                for (int col = 0; col < tab.GetLength(1); col++)
                {
                    if((col >= borne) & (col <= largeur_max -1 - borne))
                    {
                        tab[ligne, col] = retour(tab[ligne + 1, col] + 8);
                    }

                    else
                    {
                        tab[ligne, col] = -1;
                    }
                }
                borne += 1;
                
            }

            //print la pyramide
            for(int ligne = 0; ligne < tab.GetLength(0); ligne++)
            {
                for (int col = 0; col < tab.GetLength(1); col++)
                {
                    if(tab[ligne, col] >= 0)
                    {
                        Console.Write(tab[ligne, col]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }

            //Console.WriteLine(tab.GetLength(0));
            //Console.WriteLine(tab.GetLength(1));
            
            //for(int col = 0; col < tab.GetLength(1); col++)
            //{
            //    Console.Write(tab[9, col]);
            //}
        }

        static void Main(string[] args)
        {
            pyramide();
            Console.ReadKey();
        }
    }
}
