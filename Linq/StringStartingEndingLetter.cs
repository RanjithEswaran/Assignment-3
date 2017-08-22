using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStartingEndingLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfStrings;
            Console.WriteLine("Enter the number of strings");
            NumberOfStrings = Convert.ToInt16(Console.ReadLine());
            string[] StringSet = new string[NumberOfStrings];
            Console.WriteLine("Enter the strings");
            for(int i=0;i<NumberOfStrings;i++)
            {
                StringSet[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Enter the starting character");
            char StartingChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the ending character");
            char EndingChar = Convert.ToChar(Console.ReadLine());
            var RequiredName = from names in StringSet where names.ElementAt(0) == StartingChar && 
                               names.ElementAt(names.Length - 1) == EndingChar select names;
            foreach(var Names in RequiredName)
            {
                Console.WriteLine("The name starting with {0} and ending with {1} is {2}",StartingChar,EndingChar, Names);
            }
            Console.ReadLine();
        }
    }
}
