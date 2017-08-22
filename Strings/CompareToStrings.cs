using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareToStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string String1, String2;
            int c = 0;
            Console.WriteLine("Enter the String 1");
            String1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the String 2");
            String2 = Convert.ToString(Console.ReadLine());
            if(String1.Length==String2.Length)
            {
                for(int i=0;i<String1.Length;i++)
                {
                    if (String1[i] == String2[i])
                        c++;
                }
                if (c == String1.Length)
                    Console.WriteLine("They are same");
                else
                    Console.WriteLine("They are different");
            }
            else
                Console.WriteLine("They are different");
            Console.ReadKey();
        }
    }
}
