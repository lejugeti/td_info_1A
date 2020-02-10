using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5
{
    class Program
    {
        public static double ConversionCelsiusToF(int celsius)
        {
            return celsius * (9.0 / 5.0) + 32;
        }

        public static double ConversionFToCelsius(int f)
        {
            return (f - 32) / (9.0 / 5.0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConversionCelsiusToF(-20));
            Console.WriteLine(ConversionCelsiusToF(0));
            Console.WriteLine(ConversionCelsiusToF(90));

            Console.WriteLine(ConversionFToCelsius(-40));
            Console.WriteLine(ConversionFToCelsius(0));

            Console.ReadKey();
        }
    }
}
