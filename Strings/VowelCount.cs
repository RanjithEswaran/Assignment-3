using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string TestString = Convert.ToString(Console.ReadLine());
            int VowelCount = 0, ConsonantCount = 0;

            for (int i = 0; i < TestString.Length; i++)
            {
                if (TestString[i] >= 'A' && TestString[i] <= 'Z' || TestString[i] >= 'a' && TestString[i] <= 'z')
                {
                    if (TestString[i] == 'A' || TestString[i] == 'E' || TestString[i] == 'I' ||
                           TestString[i] == 'O' || TestString[i] == 'U' || TestString[i] == 'a' || TestString[i] == 'e' || TestString[i] == 'i' ||
                           TestString[i] == 'o' || TestString[i] == 'u')
                        VowelCount++;
                    else
                        ConsonantCount++;

                }
               
            }
            Console.WriteLine("\nVowels = {0}\nConsonants = {1}", VowelCount, ConsonantCount);
            Console.ReadKey();
        }
    }
}
