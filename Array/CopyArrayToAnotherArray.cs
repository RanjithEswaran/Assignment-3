using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArrayToAnotherArray
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the size of the array");
                int len = Convert.ToInt16(Console.ReadLine());
                int[] arrray = new int[len];
                Console.WriteLine("Enter the array");
                for (int i = 0; i < len; i++)
                {
                    arrray[i] = Convert.ToInt16(Console.ReadLine());
                }
                int[] arrrayCopy = new int[len];
                for (int i = 0; i < len; i++)
                {
                    arrrayCopy[i] = arrray[i];
                }
                Console.WriteLine("The elements in the copied array are");
                for (int i = 0; i < len; i++)
                {
                    Console.WriteLine("{0}", arrrayCopy[i]);
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();

        }
    }
}
