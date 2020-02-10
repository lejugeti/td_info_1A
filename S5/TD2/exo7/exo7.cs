using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7
{
    class Program
    {
        public static int comptage_doublets(string phrase)
        {
            phrase = phrase.ToLower();
            int compteur = 0;

            if(phrase.Length == 0)
            {
                return compteur;
            }

            else
            {
                for (int i = 1; 0 < i & i < phrase.Length - 1; i += 1)
                {
                    if(i == 1)
                    {
                        string lettre_1 = phrase[i - 1].ToString();
                        string lettre_2 = phrase[i].ToString();
                        string lettre_3 = phrase[i + 1].ToString();
                        
                        if (lettre_1 == lettre_2 & lettre_2 != lettre_3)
                        {
                            compteur += 1;
                        }
                    }

                    else
                    {
                        string lettre_1 = phrase[i - 2].ToString();
                        string lettre_2 = phrase[i-1].ToString();
                        string lettre_3 = phrase[i].ToString();
                        string lettre_4 = phrase[i + 1 ].ToString();


                        if (lettre_3 == lettre_2 & lettre_1 != lettre_3 & lettre_4 != lettre_3)
                        {
                            compteur += 1;
                        }
                    }
                    

                }

                return compteur;
            }
            
        }

        public static int comptage_s(string phrase)
        {
            phrase = phrase.ToLower();
            int compteur = 0;

            if (phrase.Length == 0)
            {
                return compteur;
            }

            else
            {
                for (int i = 0; i < phrase.Length - 1; i += 1)
                {
                    string lettre_1 = phrase[i].ToString();
                    string lettre_2 = phrase[i + 1].ToString();

                    if (lettre_1 == lettre_2 & lettre_1 == "s")
                    {
                        compteur += 1;
                    }

                }

                return compteur;
            }

        }
        static void Main(string[] args)
        {
            string phrase = "Oolithe est un mooot bizarre, assez connu des assidus géologues.";
            /*string phrase = "o";
            string phrase = "";*/
            int nb_doublets = comptage_doublets(phrase);
            int nb_s = comptage_s(phrase);

            Console.WriteLine(nb_doublets);
            Console.WriteLine(nb_s);
            //Console.WriteLine(phrase[0].ToString().GetType());
            Console.ReadKey();
            
        }
    }
}

