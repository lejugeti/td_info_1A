using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    
    class Program
    {
        public static bool mdp()
        {
            Console.WriteLine("rentrez votre mot de passe à 4 chiffres");
            string texte = Console.ReadLine();

            if (texte.Length == 4)
            {
                Console.WriteLine("c'est bonnnnnnnnnn");
                Console.WriteLine("tapez pour fermer la fenêtre");
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Main(string[] args)
        {
            int compteur = 0;
            bool done = false;
            while (done == false & compteur < 3)
            {
                
                done = mdp();
                compteur += 1;
                
            }
            Console.ReadKey();
        }
    }
}
