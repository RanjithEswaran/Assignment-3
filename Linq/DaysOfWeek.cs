using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = { "Sunday", "Monday", "Tuesday", "wednesday", "Thursday", "Friday", "Saturday" };
            var days = from day in week select day;
            Console.WriteLine("The days of the week are");
            foreach(var Days in days)
            {
                Console.WriteLine("{0}", Days);
            }
            Console.ReadKey();
        }
    }
}
