using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    class Program
    {
        public static void sapin(int hauteur, string symbole)
        {
            double largeur_max = hauteur * 2 ;

            Console.WriteLine($"Hauteur du sapin = {hauteur}");
            Console.WriteLine("================");
            Console.WriteLine("  Sapin Plein  ");
            Console.WriteLine("================");
            //for (int n = 0; n < hauteur; ++n)
            //{
            //    for (int m = 0; m <= largeur_max; ++m)
            //    {
            //        if(m < Math.Round(largeur_max/2) - n | Math.Round(largeur_max/2) + n < m)
            //        {
            //            Console.Write(" ");
            //        }

            //        else
            //        {
            //            Console.Write(symbole);
            //        }

            //    }

            //    Console.WriteLine(" ");
            //}
            int milieu = (int) Math.Round(largeur_max / 2);
            int[,] sapin = new int[hauteur, (int) largeur_max];
            int borne = 0;

            for(int ligne = 0; ligne < hauteur; ligne += 1)
            {
                for(int col = 0; col < largeur_max; col += 1)
                {
                    //Console.WriteLine($"ligne = {ligne}, col = {col}, borne = {borne}");
                    if (col < milieu -1 - borne | col > milieu -1 + borne)
                    {
                        sapin[ligne, col] = 0;
                    }

                    else
                    {
                        sapin[ligne, col] = 1;
                    }
                    
                }
                borne += 1;
            }

            for (int ligne = 0; ligne < hauteur; ligne++)
            {
                for (int col = 0; col < largeur_max; col++)
                {
                    //Console.WriteLine($"ligne = {ligne}, col = {col}");
                    if (sapin[ligne, col] == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(symbole);
                    }
                }
                Console.WriteLine(" ");

            }

            Console.WriteLine("================");
            Console.WriteLine("  Sapin Vide  ");
            Console.WriteLine("================");

            int[,] sapin_2 = new int[hauteur, (int)largeur_max];
            borne = 0;

            for (int ligne = 0; ligne < hauteur; ligne += 1)
            {
                for (int col = 0; col < largeur_max; col += 1)
                {
                    //Console.WriteLine($"ligne = {ligne}, col = {col}, borne = {borne}");
                    if(ligne == hauteur - 1 & col < sapin_2.GetLength(1) -1 )
                    {
                        sapin_2[ligne, col] = 1;
                    }
                    else if (col == milieu -1 - borne | col == milieu -1 + borne)
                    {
                        sapin_2[ligne, col] = 1;
                    }

                    else
                    {
                        sapin_2[ligne, col] = 0;
                    }

                }
                borne += 1;
            }

            for (int ligne = 0; ligne < hauteur; ligne++)
            {
                for (int col = 0; col < largeur_max; col++)
                {
                    //Console.WriteLine($"ligne = {ligne}, col = {col}");
                    if (sapin_2[ligne, col] == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(symbole);
                    }
                }
                Console.WriteLine(" ");

            }
        }
        static void Main(string[] args)
        {
            sapin(4, "*");
            Console.ReadKey();
        }
    }
}
