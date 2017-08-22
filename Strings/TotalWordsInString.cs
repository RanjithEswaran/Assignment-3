using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWordsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            int WordCount = 1;
            Console.WriteLine("Enter the sentence");
            string Sentence = Convert.ToString(Console.ReadLine());
                for (int i = 0; i < Sentence.Length; i++)
                {
                    if (Sentence[i] == ' ')
                        WordCount++;
                }
            Console.WriteLine("The number of words in the Sentence is {0}", WordCount);
            Console.ReadKey();
        }
    }
}
