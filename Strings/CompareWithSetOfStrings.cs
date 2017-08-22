using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareWithSetOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string TestString;
            Console.WriteLine("Enter the number of strings in string set");
            int NumberOfStrings = Convert.ToInt16(Console.ReadLine());
            string[] StringSet = new string[NumberOfStrings];
            Console.WriteLine();
            for (int i=0;i<NumberOfStrings;i++)
            {
                Console.WriteLine("Enter the String");
                StringSet[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Enter the string to search");
            TestString = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            for (int i=0;i<NumberOfStrings;i++)
            {
                if(TestString.Equals(StringSet[i]))
                    Console.WriteLine("{0} is matched with string {1}",TestString,i+1);
            }
            Console.ReadKey();
        }
    }
}
