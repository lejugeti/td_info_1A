using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Program
    {
        public static void conversion_jour(int nombre, string type)
        {
            int[] tab = new int[4];

            if (type == "secondes")
            {
                tab[3] = nombre % 60;
                tab[2] = nombre / 60;
                tab[1] = tab[2] / 60;
                tab[2] = tab[2] % 60;
                tab[0] = tab[1] / 24;
                tab[1] = tab[1] % 24;

                Console.WriteLine($"{tab[0]}j {tab[1]}h {tab[2]}min {tab[3]}sec");
            }

            else if(type == "minutes")
            {
                tab[2] = nombre;
                tab[1] = tab[2] / 60;
                tab[2] = tab[2] % 60;
                tab[0] = tab[1] / 24;
                tab[1] = tab[1] % 24;

                Console.WriteLine($"{tab[0]}j {tab[1]}h {tab[2]}min {tab[3]}sec");
            }

            else
            {
                tab[1] = nombre;
                tab[0] = tab[1] / 24;
                tab[1] = tab[1] % 24;

                Console.WriteLine($"{tab[0]}j {tab[1]}h {tab[2]}min {tab[3]}sec");
            }
        }

        static void Main(string[] args)
        {
            double[] tab = new double[3];
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Veuillez saisir la valeur n°{i + 1}");
                tab[i] = Double.Parse(Console.ReadLine());

            }

            Minimum.ProcMin3Reels(tab[0], tab[1], tab[2]);
            conversion_jour(93666, "secondes");
            Console.ReadKey();
        }
    }
}
