using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            Console.WriteLine("Enter the string");
            str=Convert.ToString(Console.ReadLine());
            char[] StrArray = str.ToCharArray();
            Array.Reverse(StrArray);
            Console.WriteLine("The reversed String is");
            for (int i = 0; i < StrArray.Length; i++)
                Console.Write("{0}", StrArray[i]);
            Console.ReadKey();

        }
    }
}
