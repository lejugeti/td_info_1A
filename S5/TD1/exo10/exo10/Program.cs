using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo10
{
    class Program
    {
        public static string categorie(int age)
        {
            if (6 <= age & age <= 7)
            { return "Poussin"; }

            else if (8 <= age & age <= 9)
            { return "Pupille"; }

            else if (10 <= age & age <= 11)
            { return "Minime"; }

            else if (12<= age)
            { return "Cadet"; }

            else { return "rien"; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(categorie(6));
            Console.WriteLine(categorie(7));
            Console.WriteLine(categorie(8));
            Console.WriteLine(categorie(9));
            Console.WriteLine(categorie(10));
            Console.WriteLine(categorie(11));
            Console.WriteLine(categorie(12));
            Console.WriteLine(categorie(16));
            Console.ReadKey();
        }
    }
}
