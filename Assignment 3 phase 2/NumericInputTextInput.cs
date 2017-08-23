using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericInputTextInput
{
    class TextInput
    {
        string stringValue;
        public TextInput()
        {
            stringValue = "";
        }
        public virtual void Add(char c)
        {
            stringValue += c;
        }
        public virtual string GetValue()
        {
            return this.stringValue;
        }
    }
    class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if (c >= '0' && c <= '9')
                base.Add(c);
        }
        public override string GetValue()
        {
            return base.GetValue();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Choice;
                char c;
                do {
                    TextInput input = new NumericInput();

                    do
                    {
                        Console.WriteLine("Enter the Character");
                        c = Convert.ToChar(Console.ReadLine());
                        input.Add(c);

                        Console.WriteLine("Do you want to continue? Yes/No");
                        Choice = Convert.ToString(Console.ReadLine());

                    } while (Choice.Equals("Yes") || Choice.Equals("YES") ||
                    Choice.Equals("yes") || Choice.Equals("Y") || Choice.Equals("y"));

                    Console.WriteLine();
                    Console.WriteLine("The given numeric string is {0}", input.GetValue());
                    Console.WriteLine();

                    Console.WriteLine("Do you want to continue typing new string ? Yes/No");
                    Choice = Convert.ToString(Console.ReadLine());
                } while (Choice.Equals("Yes") || Choice.Equals("YES") ||
                    Choice.Equals("yes") || Choice.Equals("Y") || Choice.Equals("y"));

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }
    }
}
