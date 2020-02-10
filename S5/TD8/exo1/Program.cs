using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    class Program
    {
        public static bool rechercheMotif(int[] t1, int[] t2)
        {
  
            for(int i = 0; i < t2.Length - t1.Length; i++)
            {
                int compteur = 0;

                for(int j = 0; j < t1.Length; j++)
                {
                    if(t1[j] == t2[i + j])
                    {
                        compteur++;
                    }
                }

                if(compteur == t1.Length)
                {
                    return true;
                }
            }

            return false;
        }

        public static void afficheUnique(int[] tab)
        {
            int nb_diff = 0;
            
            foreach (int val in tab.Distinct())
            {
                nb_diff++;
            }

            int[,] unique = new int[nb_diff, 2];

            int i = 0;
            foreach (int val in tab.Distinct())
            {
                unique[i, 0] = val;
                i++;
            }
            
            for( i = 0;  i< unique.GetLength(0); i++)
            {
                for(int j = 0; j < tab.Length; j++)
                {
                    if(unique[i,0] == tab[j])
                    {
                        unique[i, 1]++;
                    }
                }
            }

            for(i = 0; i < unique.GetLength(0); i++)
            {
                if(unique[i, 1] == 1)
                {
                    Console.WriteLine(unique[i, 0]);
                }
            }
        }

        public static int plusLongueSeq(int[] tab)
        {
            int max = 0;
            int i = 0;

            while(i < tab.Length -1)
            {
                
                int count = 1;
                for(int j = i; j < tab.Length-1; j++)
                {
                    if(tab[j] <= tab[j + 1])
                    {
                        count++;
                    }

                    else
                    {
                        i = j + 1;
                        break;
                    }
                }

                if(count > max)
                {
                    max = count;
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            int[] t1 = { 1, 2, 3 };
            int[] t2 = { 3, 4, 1, 2, 3, 2, 1 };
            int[] t3 = { 0, 1, 1, 2, 2, 4, 7, 7, 7 };
            int[] t4 = { 0, 2, 3, 5, 3, 4, 5, 10, 11, 11, 5 };

            //Console.WriteLine(rechercheMotif(t1, t2));
            //afficheUnique(t3);
            Console.WriteLine(plusLongueSeq(t4));

            Console.ReadKey();
        }
    }
}
