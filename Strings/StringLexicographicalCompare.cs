using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLexicographicalCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            String string1, string2;
            
            Console.WriteLine("Enter the String 1");
            string1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the String 2");
            string2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(".............................");
            if (string1.CompareTo(string2) == 0)
            {
                Console.WriteLine("They are Equal");
            }
            else if (string1.CompareTo(string2) > 0)
                Console.WriteLine("String 1 is greater than String 2");
            else
                Console.WriteLine("String 1 is Less than String 2");
            Console.ReadKey();
        }
    }
}
