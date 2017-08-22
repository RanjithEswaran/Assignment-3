using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMethodDemo
{
    class GenDemo<T>
    {
        public string GenMethod(T arg)
        {
            String s= arg.ToString();
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            object Data;
            double DataFloat;
            string Choice = "y";
            try
            {
                do
                {
                    Console.WriteLine("Enter your Data");
                    Data = Console.ReadLine();
                    GenDemo<object> genDemo = new GenDemo<object>();
                    Console.WriteLine("The output is");
                    string Answer = genDemo.GenMethod(Data);
                    Console.WriteLine("You entered {0}", Answer);
                    Console.WriteLine("Do you want to continue? Yes/No");
                    Choice = Convert.ToString(Console.ReadLine());
                } while (Choice.Equals("Yes") || Choice.Equals("YES") || Choice.Equals("Y") || Choice.Equals("y"));
            }
            catch
            {
                Console.WriteLine("Invalid");
            }
           
            Console.ReadKey();

        }
    }
}
