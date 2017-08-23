using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateCharacterFromString
{
    class Program
    {
        public static string RemoveDuplicates(string TestString)
        {
            StringBuilder sb = new StringBuilder(TestString);
            int index = 0, j;
            for (int i = 0; i < TestString.Length; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (sb[i] == sb[j])
                        break;
                }
                if (i == j)
                    sb[index++] = sb[i];
            }
            TestString = sb.ToString().Substring(0, pos);
            return TestString;
        }
        public static string RemoveDuplicate(string TestString)
        {
            string str="";
            StringBuilder TestStringBuilder = new StringBuilder(TestString);
            for (int i = 0; i < TestStringBuilder.Length - 1; i++)
            {
                for (int j = i + 1; j < TestStringBuilder.Length; j++)
                {
                    if (TestStringBuilder[i] != '\0' && TestStringBuilder[j] != '\0')
                    {
                        if (TestStringBuilder[i]== TestStringBuilder[j])
                            TestStringBuilder[j] = '\0';
                    }
                }
            }
            for(int i=0;i<TestStringBuilder.Length;i++)
            {
                if (TestStringBuilder[i] != '\0')
                    str += TestStringBuilder[i];
            }
            return str;
        }
        static void Main(string[] args)
        {
            try
            {
                string TestString,Choice;
                do {
                    Console.WriteLine("Enter the string");
                    TestString = Convert.ToString(Console.ReadLine());
                    TestString = Program.RemoveDuplicate(TestString);
                    Console.WriteLine();
                    Console.WriteLine("The string after removing duplicates is {0}", TestString);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to continue? Yes/No");
                    Choice = Convert.ToString(Console.ReadLine());
                } while (Choice.Equals("Yes")|| Choice.Equals("yes")||
                Choice.Equals("YES")|| Choice.Equals("Y")|| Choice.Equals("y"));
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
                Console.ReadLine();
            }
        
    }
}
