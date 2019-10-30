using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9
{
    class Program
    {
        public static int[] classeur(int[] tab, int i)
        {
            if (tab[i] > tab[i+1])
            { int temp = tab[i+1];
                tab[i + 1] = tab[i];
                tab[i] = temp;
            }
            return tab;
            


        }
        static void Main(string[] args)
        {
            int[] t = new int[] { 2,3, 1 };
            t = classeur(t, 0);
            t = classeur(t, 1);
            if (t[1]<t[0])
            {
                int temp = t[0];
                t[0] = t[1];
                t[1] = temp;
            }
            Console.WriteLine($"{t[0]}, {t[1]}, {t[2]}");
            Console.ReadKey();
        }
    }
}
