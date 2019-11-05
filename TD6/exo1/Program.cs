using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    class Ex1
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int resultat = 1;
            int taille = 5;
            int[] tab = new int[taille];

            while (i < taille)
            {
                Console.WriteLine($"l'element n°{i} vaut ?");
                tab[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            for (i = 0; i < taille; i++)
            {
                resultat = resultat * tab[i];
            }

            Console.WriteLine("Le produit des elements du tableau vaut : ");
            Console.WriteLine(resultat);
            Console.ReadKey();
        }
    }
}
