using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Program
    {
        public static void multi_sapin(string mode)
        {
            int nbmotifs = 3;
            int h = 5;
            string symbole = "*";

            int longueur_max = h * 2 - 1;
            int borne = 0;
            string[,] sapin = new string[h, longueur_max];

            for(int ligne = h - 1; ligne >= 0; ligne--)
            {
                for(int col = 0; col < sapin.GetLength(1); col++)
                {
                    if (mode == "plein" | mode == "inverse")
                    {
                        if (borne <= col & col < sapin.GetLength(1) - borne)
                        {
                            sapin[ligne, col] = symbole;
                        }

                        else
                        {
                            sapin[ligne, col] = " ";
                        }
                    }

                    else if (mode == "vide")
                    {
                        if(ligne == h - 1)
                        {
                            sapin[ligne, col] = symbole;
                        }

                        else
                        {
                            if (col == borne | col == sapin.GetLength(1) - borne -1)
                            {
                                sapin[ligne, col] = symbole;
                            }

                            else
                            {
                                sapin[ligne, col] = " ";
                            }
                        }
                        
                    }

                    
                }

                borne++;
            }

            if(mode == "plein" )
            {
                //écriture premier étage
                for (int ligne = 0; ligne < h; ligne++)
                {
                    for (int col = 0; col < sapin.GetLength(1); col++)
                    {
                        Console.Write(sapin[ligne, col]);
                    }
                    Console.WriteLine();
                }

                //écriture autres étages
                for (int nb_sapin = 0; nb_sapin < nbmotifs - 1; nb_sapin++)
                {
                    for (int ligne = 1; ligne < h; ligne++)
                    {
                        for (int col = 0; col < longueur_max; col++)
                        {
                            Console.Write(sapin[ligne, col]);
                        }
                        Console.WriteLine(" ");
                    }

                }
            }

            else
            {
                //écriture premiers étages
                for (int nb_sapin = 0; nb_sapin < nbmotifs - 1; nb_sapin++)
                {
                    for (int ligne = h - 1; ligne >= 1; ligne--)
                    {
                        for (int col = 0; col < sapin.GetLength(1); col++)
                        {
                            Console.Write(sapin[ligne, col]);
                        }
                        Console.WriteLine();
                    }
                }

                //écriture dernier étage
                for (int ligne = h - 1; ligne >= 0; ligne--)
                {
                    for (int col = 0; col < longueur_max; col++)
                    {
                        Console.Write(sapin[ligne, col]);
                    }
                    Console.WriteLine(" ");
                }


            }
            
 
        }

        public static void sapin_vide()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("SAPIN PLEIN");
            Console.WriteLine("==========================");
            multi_sapin("plein");

            Console.WriteLine(" ");
            Console.WriteLine("==========================");
            Console.WriteLine("SAPIN VIDE");
            Console.WriteLine("==========================");
            multi_sapin("vide");

            Console.WriteLine(" ");
            Console.WriteLine("==========================");
            Console.WriteLine("SAPIN INVERSE");
            Console.WriteLine("==========================");
            multi_sapin("inverse");

            Console.ReadKey();
        }
    }
}
