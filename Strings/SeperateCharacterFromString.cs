using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeperateCharacterFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            string TestString;
            Console.WriteLine("Enter the String");
            TestString = Convert.ToString(Console.ReadLine());
            foreach(char character in TestString)
            {
                Console.WriteLine("{0}", character);
            }
            Console.ReadKey();
        }
    }
}
