using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Radius To Find The Area Of Circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            area(ref radius);
            Console.Write("ENter The Radius To Find The Circumference Of Circle:");
            radius = Convert.ToDouble(Console.ReadLine());
            circumtance(ref radius);
            Console.ReadLine();
        }
        static void area(ref double value)
        {
            double area;
            area = Math.PI * (value * value);
            Console.WriteLine("Area OF Circle:" + area);
        }

        static void circumtance(ref double v)
        {
            double result;
            result = Math.PI * 2 * v;
            Console.WriteLine("Circumference of circle:" + result);

        }
    }
}