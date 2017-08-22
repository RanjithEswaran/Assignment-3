using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastAdditionMultiplication
{
    class Program
    {
     
        public delegate void CallFunction(int Number1, int Number2);
        static void Main(string[] args)
        {
            try {
                int Number1, Number2;
                Console.WriteLine("Enter the Number 1");
                Number1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the Number 2");
                Number2 = Convert.ToInt16(Console.ReadLine());
                CallFunction Function = new CallFunction(Multiplication);
                Function += Addition;
                Console.WriteLine();
                Console.WriteLine("Calling the Functions By Delegates");
                Console.WriteLine();
                Function(Number1, Number2);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
        static void Multiplication(int Number1, int Number2)
        {
            Console.WriteLine("{0} * {1} = {2}", Number1, Number2, Number1 * Number2);
            Console.WriteLine();
        }
        static void Addition(int Number1, int Number2)
        {
            Console.WriteLine("{0} + {1} = {2}", Number1, Number2, Number1 + Number2);
        }
    }
}
