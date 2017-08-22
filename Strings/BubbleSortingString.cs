using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string TestString;
            TestString = Convert.ToString(Console.ReadLine());
            StringBuilder stringBuild = new StringBuilder(TestString);
            char Temp;
            for(int i=0;i<TestString.Length-1;i++)
            {
                for(int j=0;j<TestString.Length-i-1;j++)
                {
                   if(stringBuild[j]>stringBuild[j+1])
                    {
                        Temp = stringBuild[j];
                        stringBuild[j] = stringBuild[j + 1];
                        stringBuild[j + 1] = Temp;
                    }
                }
                Console.WriteLine("Iteration {0} : {1}", i + 1, stringBuild);
            }
            Console.WriteLine();
            Console.WriteLine("String After Bubble Sort : {0}", stringBuild);
            Console.ReadKey();
        }
    }
}
