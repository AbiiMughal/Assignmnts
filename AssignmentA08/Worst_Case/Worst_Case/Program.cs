using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worstCase
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter Unique Numbers");
            for (int i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 10 && number < 100)
                {
                    if (CheckUnique(arr, number))
                    {
                        arr[i] = number;
                    }
                    else
                    {
                        Console.WriteLine("Enter Unique Value:");
                    }
                }
                else
                {
                    Console.WriteLine("Enter number in btw 10 to 100");
                }
            }
           
           
        }
        static bool CheckUnique(int[] num, int v)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == v)
                {
                    return false;
                }
            }
            return true;
        }
    }
}