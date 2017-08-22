using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayAscending
{
    class ArraySortAscending
    {
        public static void SortAscending(int[] array, int len)
        {
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int len = Convert.ToInt16(Console.ReadLine());
            int[] array = new int[len];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < len; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            ArraySortAscending.SortAscending(array, len);
            Console.WriteLine("Array sorted in Ascending order");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
            Console.ReadKey();
        }
    }
}
