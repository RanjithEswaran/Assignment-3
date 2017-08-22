using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string TestString = Convert.ToString(Console.ReadLine());
            int Length = 0;
            foreach (char character in TestString)
            {
                Length++;
            }
            Console.WriteLine("The length of the string is {0}", Length);
            Console.ReadKey();
        }
    }
}
