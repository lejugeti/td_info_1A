using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3
{
    class Program
    {
        public static void recherche_ligne(int[] tab)
        {
            

            Console.WriteLine("Position à tester ?");
            int pos_test = Int32.Parse(Console.ReadLine());
            int nb_test = tab[pos_test -1];

            int[] tab_verif = new int[tab.Length];

            for (int i = 0; i < tab_verif.Length; i++)
            {
                if(tab[i] == nb_test & i != pos_test -1)
                {
                    tab_verif[i] = 1;
                }
                else
                {
                    tab_verif[i] = 0;
                }
            }

            //for(int i = 0; i < tab_verif.Length; i++)
            //{
            //    Console.Write(tab_verif[i]);
            //}

            Console.WriteLine($"La valeur {tab[pos_test - 1]} est présente en colonne {pos_test}");
            
            if(tab_verif.Sum() != 0)
            {
                Console.Write("cette valeur apparaît aussi en position");
                for (int i = 0; i < tab_verif.Length; i++)
                {
                    if(tab_verif[i] == 1)
                    {
                        Console.Write($"[{i + 1}]");
                    }
                    
                }
            }
            else
            {
                Console.Write(" ");
            }
            
        }

        public static void verif_ligne(int[] tab)
        {
            int nb_faute = 0;
            int[] tab_verif;
            int[] verif_done = new int[tab.Length];

            for (int index_test = 0; index_test < tab.Length; index_test++)
            {
                int nb_test = tab[index_test];

                if (verif_done.Contains(nb_test))
                {
                    Console.Write("");
                }

                else
                {
                    verif_done[index_test] = nb_test;
                    tab_verif = new int[tab.Length];


                    for (int i = 0; i < tab_verif.Length; i++)
                    {
                        if (tab[i] == nb_test & i != index_test)
                        {
                            tab_verif[i] = 1;
                            nb_faute++;
                        }
                        else
                        {
                            tab_verif[i] = 0;
                        }
                    }


                    if (tab_verif.Sum() != 0)
                    {
                        Console.WriteLine($"La valeur {tab[index_test]} située en colonne {index_test + 1}");

                        for (int i_verif = 0; i_verif < tab_verif.Length; i_verif++)
                        {
                            if (tab_verif[i_verif] == 1)
                            {
                                Console.WriteLine($"est aussi présente en [{i_verif + 1}]");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }


                    }
                }
                
            }
        }

        public static void verif_sudoku(int[,] grille)
        {
            
            int nb_faute = 0;

            //verif lignes
            for (int ligne = 0; ligne < grille.GetLength(0); ligne++)
            {
                
            }
        }


        static void Main(string[] args)
        {
            int[] tab = { 2, 1, 5, 1, 3, 6, 7, 8, 9 };
            int[] tab1 = { 2, 1, 5, 3, 3, 6, 7, 8, 9 };
            int[] tab2 = { 3, 4, 1, 2, 3, 7, 1, 4, 1 };

            int[,] grille = {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                {2,3,4,5,6,7,8,9,1 },
                {3,4,5,6,7,8,9,1,2 },
                {4,5,6,7,8,9,1,2,3 },
                {5,6,7,8,9,1,2,3,4 },
                {6,5,8,9,1,2,3,4,7 },
                {7,8,9,1,2,3,4,5,6 },
                {3,9,1,2,3,4,3,6,7 },
                {9,1,2,3,4,5,6,7,8 }};

            //verif_ligne(tab2);
            Console.ReadKey();
        }
    }
}
