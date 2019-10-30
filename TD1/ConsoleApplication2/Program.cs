using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7
{
    class Program
    {public static int[] lendemain(int[] today)
        { int[] jours = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
          if (today[2]%4 == 0)
            { jours[1] = 29; }

            today[0] = today[0] + 1;

            if(today[0] > jours[today[1]-1])
            { today[0] = 1;
              today[1] = today[1] + 1;
                if (today[1] > 12)
                { today[1] = 1;
                  today[2] = today[2] + 1;
                }
            }
            return today;
        }
        static void Main(string[] args)
        {
            int[] jour = new int[] { 31, 12, 2009 };
            int[] demain = lendemain(jour);
            Console.WriteLine($"demain on sera le {demain[0]}/{demain[1]}/{demain[2]}");
            Console.ReadKey();
        }
    }
}
