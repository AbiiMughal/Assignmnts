using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] primeNumbers = new bool[100];
            FillArray(primeNumbers);
            CheckPrime(primeNumbers);
            PrintPrimeNumbers(primeNumbers);
            Console.ReadLine();
        }

        private static void PrintPrimeNumbers(bool[] primeNumbers)
        {
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                if (primeNumbers[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void CheckPrime(bool[] primeNumbers)
        {
            for (int i = 2; i < primeNumbers.Length; i++)
            {
                if (primeNumbers[i] == true)
                {
                    int j = i;
                    while (j < primeNumbers.Length)
                    {
                        j += i;
                        if (j < primeNumbers.Length)
                        {
                            primeNumbers[j] = false;
                        }
                    }
                }
            }
        }

        private static void FillArray(bool[] primeNumbers)
        {
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                primeNumbers[i] = true;
            }
        }
    }
}