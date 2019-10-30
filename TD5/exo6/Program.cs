using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6
{
    class Program
    {
        public static int scan(int index, int[] tab)
        {

            bool done = false;
            int compteur = 1;
            while(done == false)
            {
                if(tab[index -1 ] == tab[index])
                {
                    compteur += 1;
                }
                else
                {
                    done = true;
                }

                index++;
            }

            return compteur;
        }
        
        public static void enigme()
        {
            Console.WriteLine("Combien de lignes voulez-vous afficher ?");
            int nb_lignes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Combien de valeurs de départ ?");
            int nb_val_depart = Int32.Parse(Console.ReadLine());

            int[] val = new int[nb_val_depart+1];

            //initialisation des premières valeurs
            for (int i = 0; i < val.Length-1; i++)
            {
                Console.WriteLine($"Quelle est la valeur n°{i} ?");
                val[i] = Int32.Parse(Console.ReadLine());
            }

            for (int ligne = 0; ligne < nb_lignes; ligne++)
            {
                //int i_val = 1;
                int i_new = 0;
                int longueur_new = 1;
                //calculer longueur nouveau tableau
                for(int i = 1; i < val.Length; i++)
                {
                    if(val[i-1] != val[i])
                    {
                        longueur_new += 1;
                    }
                    else
                    {
                        longueur_new += 0;
                    }
                }
                int[] new_val = new int[(longueur_new *2) +1];
                //Console.WriteLine($"longueur_new = {longueur_new}");

                int compteur = 1;
                for(int i_val = 1; i_val < val.Length; i_val++)
                {
                    new_val[i_new] = 1;
                    if (val[i_val-1] == val[i_val])
                    {
                        compteur++;
                        //new_val[i_new] += 1;
                    }

                    else
                    {
                        //Console.WriteLine($"i_new = {i_new}");
                        new_val[i_new] = compteur;
                        new_val[i_new + 1] = val[i_val - 1];
                        compteur = 1;
                        i_new += 2;
                    }
                }

                for(int i = 0; i < val.Length; i++)
                {
                    if(val[i] != 0)
                    {
                        Console.Write(val[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");

                val = new_val;
            }
            

        }


        static void Main(string[] args)
        {
            

            enigme();
            Console.ReadKey();
        }
    }
}
