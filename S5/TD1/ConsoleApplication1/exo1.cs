using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6
{
    class Program
    { public static string Ph(int x)
        { if(x>7)
            { return "basique"; }
          else if(x<7)
            { return "acide mamène"; }
          else
            { return "neutre yes"; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Ph(3));
            Console.WriteLine(Ph(10));
            Console.WriteLine(Ph(7));
            Console.ReadKey();
        }
    }
}
