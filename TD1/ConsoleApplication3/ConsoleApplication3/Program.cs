using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {public static double remise_camescope(double prix_came, double total_facture, double reduc)
        {
            if ((500 <= prix_came) | (total_facture > 1000))
            {
                reduc += 0.1;
                return reduc;
            }
            else
            {
                return reduc;
            }
        }
      public static double remise_magneto(double prix_magneto, double total_facture, double reduc)
        {
            if ((400 <= prix_magneto) & (total_facture > 1000))
            {
                reduc += 0.15;
                return reduc;
            }
            else
            {
                return reduc;
            }
        }
        public static double remise(double total_facture, double reduc)
        {
            if (total_facture > 5000)
            {
                reduc += 0.2;
                return reduc;
            }
            else
            {
                return reduc;
            }
        }
            static void Main(string[] args)
        {
            double total = 6000;
            double camescope = 600;
            double magneto = 700;
            double reduc = 0;

            reduc = remise_camescope(camescope, total, reduc);
            reduc = remise_magneto(magneto, total, reduc);
            reduc = remise(total, reduc);

            Console.WriteLine(reduc);
            Console.ReadKey();
        }
    }
}
