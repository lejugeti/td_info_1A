using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6
{
    class Program
    {
        public static void maximum()
        {
            Console.WriteLine("Combien de nombres voulez-vous taper ?");
            int nbVal = Int32.Parse(Console.ReadLine());
            int[] tab = new int[nbVal];
            Console.WriteLine(tab.Length);
            int i = 0;
            int max = 0;
            int i_max = 0;
            while (i < tab.Length)
            {
                tab[i] = Int32.Parse(Console.ReadLine());

                if(tab[i] > max)
                {
                    max = (int) tab[i];
                    i_max = i;
                }
                i += 1;
            }
            Console.WriteLine($"Le nombre max est {max} et se trouve à l'indice i = {i_max}");
            
        }
        static void Main(string[] args)
        {
            
            maximum();
            Console.ReadKey();
        }
    }
}
