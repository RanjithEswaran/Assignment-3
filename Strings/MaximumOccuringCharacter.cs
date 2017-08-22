using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOccuringCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Test String");
            string TestString = Convert.ToString(Console.ReadLine());
            int Count = 0,MaxCount=0;
            char MaxChar = TestString[0];
            TestString.ToLower();
            Console.WriteLine();
            for(int i=0;i<TestString.Length;i++)
            {
                Count = 0;
                for(int j=i+1;j<TestString.Length;j++)
                {
                    if (TestString[i] == TestString[j])
                        Count++;
                }
                if (Count > MaxCount)
                {
                    MaxCount = Count;
                    MaxChar = TestString[i];
                }

            }
            Console.WriteLine("The maximum occuring character is {0}", MaxChar);
            Console.ReadKey();
        }
    }
}
