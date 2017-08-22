using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualCharactersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string TestString;
            Console.WriteLine("Enter the String");
            TestString = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The Reversed String is");
            for(int i=TestString.Length-1;i>=0;i--)
            {
                Console.WriteLine("{0}", TestString[i]);
            }
            Console.ReadKey();
        }
    }
}
