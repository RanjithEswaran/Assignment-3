using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string Answer = "";
            string Input;
            int StartIndex, EndIndex;
            Input = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the starting Index");
            StartIndex = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the ending Index");
            EndIndex = Convert.ToInt16(Console.ReadLine());
            if (StartIndex < EndIndex && StartIndex < Input.Length && EndIndex < Input.Length)
            {
                for (int i = StartIndex; i < EndIndex; i++)
                {
                    Answer += Input[i];
                }
                Console.WriteLine("The required Sub String is {0}", Answer);
            }
            else
                Console.WriteLine("Invalid Input");
            Console.ReadKey();
        }
    }
}
