using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    class Age
    {
        public static int CalculAge()
        {
            Console.WriteLine("Quel est votre date de naissance ?");
            string date_naissance = Console.ReadLine();
            
            
            int[] split_naissance = Array.ConvertAll(date_naissance.Split('/'), Int32.Parse);
            int[] today = Array.ConvertAll(DateTime.Now.ToString("d").Split('/'), Int32.Parse);
            int age = today[2] - split_naissance[2];
            
            if(today[1] < split_naissance[1])
            {
                age -= 1;
                return age;
            }

            else if(today[1] == split_naissance[1])
            {
                if(today[0] < split_naissance[0])
                {
                    age -= 1;
                    return age;
                }
                else
                {
                    return age;
                }
            }

            else
            {
                return age;
            }
        }
        
    }
}
