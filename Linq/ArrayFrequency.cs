using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfinputs;
            try {
                Console.WriteLine("Enter the number of elements in the Array");
                NumberOfinputs = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the number of elements in the Array");
                int[] array = new int[NumberOfinputs];

                for (int i = 0; i < NumberOfinputs; i++)
                {
                    array[i] = Convert.ToInt16(Console.ReadLine());
                }
                var Elements = from element in array group element by element into pair select pair;
                Console.WriteLine("The frequency of elements in array are");
                foreach (var j in Elements)
                {
                    Console.WriteLine("{0} appears {1} times", j.Key, j.Count());
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
