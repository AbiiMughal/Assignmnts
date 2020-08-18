
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusAndFerhenhite
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter the temperature in ferhenhite and Convert in celcius:");
            double ferh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The temperature in celcius:" + ferhenhite(ferh));
            Console.Write("ENter the temperature in celcius and COnvert in ferhenhite:");
            double cel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The temperature in ferhenhite:" + celcius(cel));
            Console.ReadLine();
        }
        static double ferhenhite(double f)
        {
            double c;
            c = 5.0 / 9.0 * (f - 32);
            return c;
        }
        static double celcius(double c)
        {
            double f;
            f = 9.0 / 5.9 * (c + 32);
            return f;
        }
    }
}