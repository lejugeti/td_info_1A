using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4
{
    class Program
    {
        public static void run_fact()
        {
            Console.WriteLine("Ecrivez un nombre pour obtenir sa factorielle");
            long nb = Int64.Parse(Console.ReadLine());
            long res = fact(nb);
            Console.WriteLine($"{nb}! = {res}");
            Console.ReadKey();

        }

        public static long fact(long nb)
        {
            if(nb == 0)
            {
                return 1;
            }
            else
            {
                return nb * fact(nb - 1);
            }
        }

        public static void run_bonjour()
        {
            bool done = false;
            while (done==false)
            {
                Console.WriteLine("Tapez 1 si vous êtes une fille, 2 si vous êtes un garçon.");
                int sexe = int.Parse(Console.ReadLine());
                if (sexe == 1 | sexe==2)
                {
                    done = true;
                    if(sexe==1)
                    {
                        Console.WriteLine("Bonjour Mademoiselle");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Bonjour Monsieur");
                        Console.ReadKey();
                    }
                    
                }
                else
                {
                    done = false;
                }

            }
            
        }


        
        static void Main(string[] args)
        {
            run_fact();
            run_bonjour();
        }
    }
}
