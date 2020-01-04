using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7
{
    class Program
    {
        public static void permut2Reels(double reel1, double reel2)
        {
            double temp = reel2;
            reel2 = reel1;
            reel1 = temp;

            Console.WriteLine($"{reel1}    {reel2}");
        }

        public static void permut2CellTab(double[] tab)
        {
            double temp = tab[0];
            tab[0] = tab[1];
            tab[1] = temp;

            Console.WriteLine($"{tab[0]}    {tab[1]}");
        }

        static void Main(string[] args)
        {
            permut2Reels(1, 2);
            double[] tab = { 1, 2 };
            permut2CellTab(tab);
            Console.ReadKey();
        }
    }
}
