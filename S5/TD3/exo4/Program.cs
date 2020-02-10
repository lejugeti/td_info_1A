using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4
{
    class Program
    {
        public static void partage(int contenance)
        {
            double litre = contenance;
            double jeune = 0;
            double vieux = 0;

            while(litre > 1)
            {
                jeune += litre / 4;
                litre = litre - litre /4;

                vieux += litre / 3;
                litre = litre - litre / 3;

            }
            Random rng = new Random();
            if(rng.Next(0, 1) == 1)
            {
                vieux += litre;
            }

            else
            {
                jeune += litre;
            }

            Console.WriteLine($"vieux prend {vieux} litres et jeune prend {jeune} litres");

        }
        static void Main(string[] args)
        {
            partage(10);
            Console.ReadKey();
        }
    }
}
