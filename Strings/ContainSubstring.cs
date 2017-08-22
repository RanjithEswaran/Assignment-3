using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Source String");
            string TestString, SubString;
            TestString = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the substring to search");
            SubString = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            if (TestString.Contains(SubString))
                Console.WriteLine("{0} is present in {1}", SubString, TestString);
            else
                Console.WriteLine("{0} is not present in {1}", SubString, TestString);
            Console.ReadKey();
        }
    }
}
