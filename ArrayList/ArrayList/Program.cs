using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class ArrayList
    {
        public int[] list;
        public int count = 0;

        public ArrayList(int a)
        {
            list = new int[a];
        }

        public ArrayList() : this(10)
        {

        }
        public void AddElement(int element)
        {

            if (count == list.Length)
            {
                NewArray();
            }
            else
            {
                list[count] = element;
                count++;
            }
        }

        public void NewArray()
        {
            int[] arr1 = new int[count + count];
            for (int i = 0; i < list.Length; i++)
            {
                arr1[i] = list[i];
            }
            list = arr1;
        }

        public void print()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public int GetIndex(int element)
        {
            int index = -1;
            if (Isempty() == true)
            {

                for (int i = 0; i < list.Length; i++)
                {

                    if (list[i] == element)
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }

        public bool Contain(int element)
        {
            if (Isempty() == true)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (element == list[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Isempty()
        {
            bool f = false;
            if (count != 0)
            {
                return true;
            }
            return f;
        }
        public void Remove(int element)
        {
            if (Isempty() == true)
            {
                int index = GetIndex(element);
                int a = index + 1;
                for (int i = a; i < list.Length; i++)
                {
                    list[i - 1] = list[i];
                }
            }
        }
        public void get(int index)
        {
            if (Isempty() == true)
            {
                if (index <= count)
                {
                    for (int i = 0; i < list.Length; i++)
                    {
                        if (i == index)
                        {
                            // Console.WriteLine("The {0} is in {1}",list[i],index);
                            Console.WriteLine(list[i]);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Index out of range!!!");
                }
            }
            else
            {
                Console.WriteLine("Your Arraylist in empty!!! ");
            }
        }
        public void InsertElementAt(int index, int element)
        {
            for (int i = index; i < list.Length; i++)
            {
                if (i + 1 != list.Length)
                {
                    int temp = list[i + 1];
                    list[i + 1] = list[i];
                }
                else
                {
                    NewArray();
                }
            }
            list[index] = element;

        }
        public int LastIndexOf(int element)
        {
            int index = -1;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == element)
                {
                    index = i;
                }
            }
            return index;
        }
        public void AddElementAt(int index, int element)
        {
            list[index] = element;
        }
        public void RemoveRange(int start, int end)
        {
            for (int z = start; z <= end; z++)
            {
                list[z] = 0;
            }
            int i, j = 0;
            for (i = 0; i < list.Length; i++)
            {
                if (i < start || i > end)
                {
                    list[j] = list[i];
                    j++;
                }
            }
        }
        public void TrimToSize()
        {
            if (count < (list.Length / 2))
            {
                int[] array = new int[(list.Length / 2) - 1];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = list[i];
                }

                list = array;
            }
        }

        public void MergeArray(ArrayList a)
        {
            int j = 0;
            int[] array = new int[a.count + count];
            for (int i = 0; i < count; i++)
            {
                array[i] = list[i];
                j++;
            }
            for (int i = 0; i < a.count; i++, j++)
            {
                array[j] = a.list[i];
            }

            list = array;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();
            a.AddElement(1);
            a.AddElement(2);
            a.AddElement(3);
            a.AddElement(4);
            a.AddElement(5);
            a.AddElement(6);
            a.AddElement(7);
            a.AddElement(8);
            a.AddElement(9);
            a.AddElement(10);
            a.AddElement(8);
            a.AddElement(8);

            a.print();

            // Console.WriteLine(a.GetIndex(3));
            //Console.WriteLine(a.Contain(4));
            //  a.get(3);
            // a.Remove(5);
            //a.print();

            Console.ReadLine();
        }
    }
}
