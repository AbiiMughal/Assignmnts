
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicacyOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i, j, num = 5;//count = 0;
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        // count++;
                        Console.WriteLine(arr[i] + " duplicate elements found in array ");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }


    }

}