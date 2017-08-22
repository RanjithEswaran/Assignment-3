using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterThan80
{
    class Program
    {
        static void Main(string[] args)
        {

            int NumberOfinputs;
            try
            {
                Console.WriteLine("Enter the number of elements in the Array");
                NumberOfinputs = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the number of elements in the Array");
                int[] array = new int[NumberOfinputs];

                for (int i = 0; i < NumberOfinputs; i++)
                {
                    Console.Write("Member {0} : ", i);
                    array[i] = Convert.ToInt16(Console.ReadLine());
                }

                int MaxValue = 80;
                var Elements = from element in array where element > MaxValue select element;
                Console.WriteLine("The elements in array greater than {0} are", MaxValue);
                int count = 1;
                foreach (var j in Elements)
                {
                    Console.WriteLine("Value {0} : {1}", count++, j);
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
