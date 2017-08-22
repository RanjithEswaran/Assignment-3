using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the String");
                string TestString = Convert.ToString(Console.ReadLine());
                var Elements = from element in TestString group element by element into pair select pair;
                Console.WriteLine("The frequency of Characters in string are");
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
