using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfinputs;
            Console.WriteLine("Enter the number of elements in the Array");
            NumberOfinputs = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the number of elements in the Array");
            int[] array = new int[NumberOfinputs];

            for (int i = 0; i < NumberOfinputs; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine();
            var Elements = from number in array select number*number;

            foreach (var j in Elements)
            {
                Console.WriteLine("Number {1}, Square {0} ", j,Math.Sqrt(j));
            }
            Console.ReadKey();
        }
    }
}
