using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        public static int[][] DiviserTableau(int[] tab, int seuil)
        {
            //déterminer le nombre d'entiers inférieurs et supérieurs au seuil
            int[] nb = StrictementSupOuInf(tab, seuil);

            int[] tabInf = new int[nb[0]];
            int[] tabSup = new int[nb[1]];

            int indexInf = 0;
            int indexSup = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < seuil)
                {
                    tabInf[indexInf] = tab[i];
                    indexInf++;
                }

                else if (tab[i] > seuil)
                {
                    tabSup[indexSup] = tab[i];
                    indexSup++;
                }
            }

            int[][] tabInfSup = new int[][] { tabInf, tabSup };

            return tabInfSup;
        }

        public static int[] tri(int[] tab)
        {
            bool done = false;

            int tmp;

            while (!done)
            {
                int count = 0;

                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        tmp = tab[i + 1];
                        tab[i + 1] = tab[i];
                        tab[i] = tmp;
                        count++;
                    }
                }


                if (count == 0)
                {
                    done = true;
                }
            }

            return tab;
        }

        public static int StrictementSup(int[] tab, int seuil)
        {
            int count = 0;

            foreach (int val in tab)
            {
                if (val < seuil) { count++; }
            }

            return count;
        }

        public static int[] StrictementSupOuInf(int[] tab, int seuil)
        {
            //count[0] représente le nombre d'entiers inférieurs au seuil
            int[] count = new int[2];

            foreach (int val in tab)
            {
                if (val < seuil) { count[0]++; }
                else if (val > seuil) { count[1]++; }
            }

            return count;
        }

        public static int[][][] NiqueSaMere(int[][] tab, int seuil)
        {
            int[] tmp;
            int[][] tabInfSup;
            int[][] tabInf = new int[tab[0].Length][];
            int[][] tabSup = new int[tab[0].Length][];
            int[][][] bigTab = new int[2][][];

            for (int ligne = 0; ligne < tab.GetLength(0); ligne++)
            {
                tmp = tri(tab[ligne]);
                tabInfSup = DiviserTableau(tmp, seuil);

                tabInf[ligne] = tabInfSup[0];
                tabSup[ligne] = tabInfSup[1];
            }

            bigTab[0] = tabInf;
            bigTab[1] = tabSup;

            return bigTab;
        }

        public static void AfficherTableau(int[,] tab)
        {
            for (int ligne = 0; ligne < tab.GetLength(0); ligne++)
            {
                for (int col = 0; col < tab.GetLength(1); col++)
                {
                    Console.Write($"{tab[ligne, col]}  ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        public static void AfficherTableau2(int[] tab)
        {
            for (int ligne = 0; ligne < tab.GetLength(0); ligne++)
            {
                Console.Write($"{tab[ligne]}  ");
            }
        }

        public static void AfficherTableau3(int[][][] tab)
        {
            //afficher inf
            for (int ligne = 0; ligne < tab[0].GetLength(0); ligne++)
            {
                for (int col = 0; col < tab[0][ligne].Length; col++)
                {
                    if (tab[0][ligne] == null)
                    {
                        Console.WriteLine("NULL");
                    }
                    else { Console.Write($"{tab[0][ligne][col]}   "); }
                }
                Console.WriteLine("");

            }

            //afficher sup
            for (int ligne = 0; ligne < tab[1].GetLength(0); ligne++)
            {
                for (int col = 0; col < tab[1][ligne].Length; col++)
                {
                    if (tab[1][ligne] == null)
                    {
                        Console.WriteLine("NULL");
                    }
                    else { Console.Write($"{tab[1][ligne][col]}   "); }
                }
                Console.WriteLine("");

            }

        }


        public static int[][][] ConvertirTSV(int[][][] rgb)
        {
            double[][] t = new double[rgb[0].GetLength(0)][];
            double[][] s = new double[rgb[0].GetLength(0)][];
            double[][] v = new double[rgb[0].GetLength(0)][];

            double[] tmpRGB;

            for (int row = 0; row < rgb[0].GetLength(0); row++)
            {
                double[] tmpT = new double[rgb[0].GetLength(1)];
                double[] tmpS = new double[rgb[0].GetLength(1)];
                double[] tmpV = new double[rgb[0].GetLength(1)];

                for (int col = 0; col < rgb[0].GetLength(1); col++)
                {
                    tmpRGB = new double[] { rgb[0][row][col], rgb[1][row][col], rgb[2][row][col] };
                    double max = tmpRGB.Max();
                    double min = tmpRGB.Min();

                    tmpV[col] = max;

                    //affectation s
                    if (max == 0)
                    {
                        tmpS[col] = 0;
                    }
                    else
                    {
                        tmpS[col] = 1 - (min / max);
                    }

                    //affectation t
                    double tmpR = tmpRGB[0];
                    double tmpG = tmpRGB[1];
                    double tmpB = tmpRGB[2];

                    if (max == min) { tmpT[col] = 0; }

                    else if (max == tmpR) { tmpT[col] = (60 * ((tmpG - tmpB) / (max - min)) + 360) % 360; }

                    else if (max == tmpG) { tmpT[col] = (60 * ((tmpB - tmpR) / (max - min)) + 120); }

                    else if (max == tmpB) { tmpT[col] = (60 * ((tmpR - tmpG) / (max - min)) + 240); }

                }

                t[row] = tmpT;
                s[row] = tmpS;
                v[row] = tmpV;
            }

            double[][][] TSV = new double[][][] { t, s, v };

            return TSV;

        }

        static void Main(string[] args)
        {
            /*int[,] tab = new int[,] { { 1, 12, 27, 15 }, { 0, -3, 4, 32 }, { 15, 0, 1, 3 } };
            AfficherTableau(tab);*/

            int[][] tab = new int[][] { new int[] { 12, 5, 18, 11, 4, 5 }, new int[] { 3, 4 }, new int[] { 1, 12, 11, 0 } };
            //Console.WriteLine(tab[0].Max());

            /*int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 4, 5, 6, 7 };
            int[][] c = new int[][] { a, b };
            
            bool bjr = !false;
            Console.Write(bjr);*/

            //int[] tab = new int[] { 12, 5, 18, 11, 4, 6 };

            //int[] newTab = tri(tab);
            //AfficherTableau2(tab);

            int[][][] bigTab = NiqueSaMere(tab, 12);
            AfficherTableau3(bigTab);
            Console.ReadKey();
        }
    }
}
