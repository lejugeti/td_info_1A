using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4c
{
    class Program
    {
        public static void phrase()
        {
            Console.WriteLine("tapez des lettres svp");
            int compteur_lettres = 0;
            int compteur_blancs = 0;
            int compteur = 0;
            bool done = false;
            
            while(done == false)
            {
                string str = Console.ReadLine();
                Console.SetCursorPosition(Console.CursorLeft + compteur, Console.CursorTop);
                if (str == ".")
                {
                    done = true;
                }
                
                else if (str == " ")
                {
                    compteur_blancs += 1;
                    compteur += 1;
                }
               
                else
                {
                    
                    compteur_lettres += 1;
                    compteur += 1;
                    
                    Console.WriteLine(str);
                    Console.SetCursorPosition(Console.CursorLeft + compteur, Console.CursorTop - 2);
                    
                }

                if (compteur_lettres == 100)
                {
                    done = true;
                }
            }
            Console.SetCursorPosition(0, Console.CursorTop+1);
            Console.WriteLine($"vous avez tapé {compteur_lettres} lettres");
            Console.WriteLine($"{compteur_blancs} espaces ont été effacés lors de la saisie");
            Console.ReadKey();



        }
        static void Main(string[] args)
        {
            phrase();
        }
    }
}
