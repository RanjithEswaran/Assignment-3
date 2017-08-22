using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenClass
{
    class GenClass<T>
    {
       public virtual T Add(T a,T b)
        {
            return a;
        }

}
    class GenInt:GenClass<int>
    {
        public override int Add(int a, int b)
        {
            return a + b;
        }
    }
    class GenString : GenClass<string>
    {
        public override string Add(string a, string b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenInt genInt = new GenInt();
            Console.WriteLine("Enter the number 1");
            int data1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            int data2 = Convert.ToInt16(Console.ReadLine());
            int sum = genInt.Add(data1, data2);
            Console.WriteLine("The sum is {0}", sum);

            GenString genString = new GenString();
            Console.WriteLine("Enter the string 1");
            string String1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the String 2");
            string String2 = Convert.ToString(Console.ReadLine());
            string answer = genString.Add(String1, String2);
            Console.WriteLine("The sum is {0}", answer);

            Console.ReadLine();

        }
    }
}
