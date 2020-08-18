
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void Check()
        {

            int number, i, m = 0, c = 0;
            Console.Write("Enter the Number to check Prime: ");
            number = Convert.ToInt32(Console.ReadLine());
            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    c = 1;
                    break;
                }
            }
            if (c == 0)
            {
                Console.Write("Number is Prime.");
            }
            Console.ReadLine();
        }
        static void primeNumber()
        {
            for (int i = 2; i <= 10000; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }

    }
}
