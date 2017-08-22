using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt16(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the array elements");
            for(int i=0;i<size;i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("The elements in reverse order in array are");
            for(int i=size-1;i>=0;i--)
            {
                Console.WriteLine("{0}",array[i]);
            }
            Console.ReadKey();
                
        }
    }
}
