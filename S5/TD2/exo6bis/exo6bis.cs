using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6bis
{
    class Program
    {
        public static void au_dessus()
        {
            Console.WriteLine("Saisissez la valeur de début");
            int valdebut = Int32.Parse(Console.ReadLine());
            bool done = false;
            int index = 0;
            int[] valeurs = new int[0];

            while (done==false)
            {
                int[] new_valeurs = new int[valeurs.Length + 1];
                if(valeurs.Length != 0)
                    for(int i = 0; i < valeurs.Length; i += 1)
                    {
                        new_valeurs[i] = valeurs[i];
                    }

                Console.WriteLine("next value");
                int temp = Int32.Parse(Console.ReadLine());
                new_valeurs[index] = temp;
                
                index += 1;
                valeurs = new_valeurs;

                if (new_valeurs[new_valeurs.Length - 1] > valdebut)
                {
                    done = true;
                    Console.WriteLine($"Valfin = {valeurs[valeurs.Length - 1]}, elle se trouve au rang i = {valeurs.Length - 1}");
                    
                    for (int i = 0; i < valeurs.Length; i += 1)
                    {
                        Console.WriteLine(valeurs[i]);
                    }
                    
                    Console.ReadKey();
                }
                /*if (temp == 0)
                {
                    done = true;
                    Console.WriteLine(new_valeurs.Length);
                    Console.ReadKey();
                }*/
            }
            

        }


        public static void intervalle()
        {
            int valdebut = 1;
            int valfin = 0;
            while(valdebut > valfin)
            {
                Console.WriteLine("la valeur de début doit être inférieure à celle de fin");
                Console.WriteLine("Saisissez la valeur de début");
                valdebut = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Saisissez la valeur de fin");
                valfin = Int32.Parse(Console.ReadLine());
            }
            

            bool done = false;
            int index = 0;
            int[] valeurs = new int[0];

            while (done == false)
            {
                int[] new_valeurs = new int[valeurs.Length + 1];
                if (valeurs.Length != 0)
                    for (int i = 0; i < valeurs.Length; i += 1)
                    {
                        new_valeurs[i] = valeurs[i];
                    }

                Console.WriteLine("next value");
                int temp = Int32.Parse(Console.ReadLine());
                new_valeurs[index] = temp;

                index += 1;
                valeurs = new_valeurs;

                if ((new_valeurs[new_valeurs.Length - 1] > valdebut) & (new_valeurs[new_valeurs.Length - 1] < valfin))
                {
                    done = true;
                    Console.WriteLine($"Valfin = {valeurs[valeurs.Length - 1]}, elle se trouve au rang i = {valeurs.Length - 1}");

                    for (int i = 0; i < valeurs.Length; i += 1)
                    {
                        Console.WriteLine(valeurs[i]);
                    }

                    Console.ReadKey();
                }
                /*if (temp == 0)
                {
                    done = true;
                    Console.WriteLine(new_valeurs.Length);
                    Console.ReadKey();
                }*/
            }
        }

            static void Main(string[] args)
        {
            //au_dessus();
            intervalle();

        }
    }
}
