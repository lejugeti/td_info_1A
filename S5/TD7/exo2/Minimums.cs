using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Minimum
    {
        public static double ProcMin2Reels(double reel1, double reel2)
        {
            return Math.Min(reel1, reel2);
        }

        public static double ProcMin3Reels(double reel1, double reel2, double reel3)
        {
            double temp = ProcMin2Reels(reel1, reel2);
            Console.Write("le plus petit des nombres entré est : ");
            Console.WriteLine(ProcMin2Reels(temp, reel3));

            return ProcMin2Reels(temp, reel3);
        }
    }
}
