using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string words;
            Console.WriteLine("Enter the String");
                words = Convert.ToString(Console.ReadLine());
            var  RequiredWords = Select(words);
            Console.WriteLine("The Words in UpperCase are :");
            foreach(var Word in RequiredWords)
            {
                Console.WriteLine("{0}", Word);
            }
            Console.ReadKey();
        }
      static  IEnumerable<string> Select(string Words)
        {
            var UpperCaseWords = Words.Split(' ');
            var Answer=UpperCaseWords
                .Where(word => String.Equals(word, word.ToUpper(),StringComparison.Ordinal));
            return Answer;
        }
    }
}
