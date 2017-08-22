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
            for(int i=0;i<NumberOfinputs;i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            var Elements = from even in array where even % 2 == 0 select even;
            Console.WriteLine("the even elements in the list are");
            foreach(var j in Elements)
            {
                Console.WriteLine("{0}", j);
            }
            Console.ReadKey();
        }
    }
}
