using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalculator
{
    interface IGenInterface<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
        T Divide(T a, T b);
    }
    class BasicMath:IGenInterface<int>
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, answer = 0;
            string choice;
            int Select;
            try
            {
                do
                {
                    Console.WriteLine("Enter the number 1");
                    number1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the number 2");
                    number2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("1.Add\n2.Subtract\n3.Multiplication\n4.Division");
                    Select = Convert.ToInt16(Console.ReadLine());
                    BasicMath basicMath = new BasicMath();
                    switch(Select)
                    {
                        case 1:
                            answer = basicMath.Add(number1, number2);
                            break;
                        case 2:
                            answer = basicMath.Subtract(number1, number2);
                            break;
                        case 3:
                            answer = basicMath.Multiply(number1, number2);
                            break;
                        case 4:
                            answer = basicMath.Divide(number1, number2);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Answer is {0}", answer);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to continue ? Yes/No");
                    choice = Convert.ToString(Console.ReadLine());
                } while (choice.Equals("Yes") || choice.Equals("Y")||
                choice.Equals("yes")||choice.Equals("YES")|| choice.Equals("y"));
                Console.WriteLine("ThankYou");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
