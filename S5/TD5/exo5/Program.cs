using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5
{
    class Program
    {
        public static void palindrome()
        {
            string mot = Console.ReadLine();
            char[] tab = mot.ToArray();
            char[] reversed = tab;
            Array.Reverse(reversed);

            int compteur = 0;
            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == reversed[i])
                {
                    compteur++;
                }
            }

            if (compteur == mot.Length)
            {
                Console.WriteLine($"{mot} est un palindrome");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{mot} n'est pas un palindrome");
                Console.ReadKey();

            }
        }

        static void Main(string[] args)
        {
            //string mot = Console.ReadLine();
            //char[] tab = mot.ToArray();
            //Console.Write(tab.GetType());
            palindrome();

        }

    }
}
