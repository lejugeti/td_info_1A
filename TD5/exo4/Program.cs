using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4
{
    class Program
    {
        public static void temperature()
        {
            int[] year = new int[] { 1951, 1952, 1953, 1954, 1955, 1956, 1957, 1958, 1959, 1960 };
            double[] temp = new double[] { 26.1, 24.5, 24.8, 24.5, 24.1, 24.3, 26.4, 24.9, 23.7, 23.5 };

            double mean = temp.Average();
            Console.WriteLine(mean);

            double max = 0;
            int year_max =0;
            for (int i = 0; i < year.Length; i++)
            {
                if (temp[i] > max)
                {
                    max = temp[i];
                    year_max = year[i];
                }
            }

            Console.WriteLine($"l'année la plus chaude est {year_max}");

            int compteur = 0;
            for(int i = 0; i < temp.Length; i++)
            {
                if(temp[i] < mean)
                {
                    compteur++;
                }
            }
            Console.WriteLine($"il y a eu {compteur} année plus froides que la moyenne");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            temperature();
        }
    }
}
