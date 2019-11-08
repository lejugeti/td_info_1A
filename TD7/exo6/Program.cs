using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6
{
    class Program
    {
        public static int[] initialiseTableauValImpaires(int taille)
        {
            int[] tab = new int[taille];

            int i = 0;
            int compteur = 0;

            while(compteur < tab.Length)
            {
                if(i % 2 != 0)
                {
                    tab[compteur] = i;
                    i++;
                    compteur++;
                }
                else
                {
                    i++;
                }
            }

            return tab;
        }
        
        public static void afficheTableau(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
        
        public static void remplit(int[] tab)
        {
            Random rng = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rng.Next();
            }
        } 

        public static bool testValeursNulle(int[] tab)
        {
            int compteur = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if(tab[i] == 0)
                {
                    compteur++;
                }
                else
                {
                    compteur = compteur;
                }
            }

            if(compteur == tab.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int calculeNombreValeursNulles(int[] tab)
        {
            int compteur = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == 0)
                {
                    compteur++;
                }
                else
                {
                    compteur = compteur;
                }
            }

            return compteur;
        }

        public static void minMoyMax(int[] tab)
        {
            int min = tab[0];
            int max = tab[0];
            double somme = tab[0];

            for(int i = 1; i < tab.Length; i++)
            {
                if(tab[i] < min)
                {
                    min = tab[i];
                }

                if(tab[i] > max)
                {
                    max = tab[i];

                }

                somme += tab[i];
            }

            Console.WriteLine($"min = {min}, max = {max}, moy = {somme / tab.Length}");
        }
        static void Main(string[] args)
        {
            //int[] tab = initialiseTableauValImpaires(5);

            //afficheTableau(tab);
            int[] tab = { 3,2,1 };
            //Console.WriteLine(testValeursNulle(tab));
            //Console.WriteLine(calculeNombreValeursNulles(tab));
            //minMoyMax(tab);
            Array.Sort(tab);
            afficheTableau(tab);
            Console.ReadKey();
        }
    }
}
