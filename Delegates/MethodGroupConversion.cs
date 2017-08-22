using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodGroupConversion
{
    class TestDelegate
    {
        public string Space(string str)
        {
            string Answer="";
            for(int i=0;i<str.Length;i++)
            {
                Answer += str[i];
                Answer += " ";
            }
            return Answer;
        }
        public string ReverseString(string str)
        {
            string s = "";
            for (int i = str.Length - 1; i >= 0; i--)
                s += str[i];
            return s;
        }
    }

    class DemoDel
    {
        public delegate string strMyDel(string str);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Test String");
            string TestString = Convert.ToString(Console.ReadLine());
            TestDelegate test = new TestDelegate();
            Console.WriteLine();
            Console.WriteLine("Calling Space Function");
            strMyDel del = new strMyDel(test.Space);
            Console.WriteLine("{0}", del(TestString));
            Console.WriteLine();
            Console.WriteLine("Calling Reverse Function");
            del = test.ReverseString;
            Console.WriteLine("{0}", del(TestString));
            Console.ReadKey();
        }
    }
}
