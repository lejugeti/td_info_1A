using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Program
    {
        public static void place_lettre()
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string lettre = Console.ReadLine();
            string tmp;

            for (int i = 0; i < alphabet.Length; i++)
            {
                tmp = alphabet[i].ToString();
                if(tmp == lettre)
                {
                    Console.Write($"la position de votre lettre dans l'alphabet est {i + 1}");
                }
            }

        }
        static void Main(string[] args)
        {
            place_lettre();
            Console.ReadKey();
        }
    }
}
