using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleByTwo
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
            int StartRange, EndRange;
            for (int i = 0; i < NumberOfinputs; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Enter the Start Range");
            StartRange = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the End Range");
            EndRange = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            var Elements = from positive in array  where positive >= StartRange && positive <= EndRange where positive > 0   select positive;
            Console.WriteLine("The positive numbers within the range of {0} and {1} are",StartRange,EndRange);
            foreach (var j in Elements)
            {
                Console.WriteLine("{0}", j);
            }
            Console.ReadKey();
        }
    }
}
