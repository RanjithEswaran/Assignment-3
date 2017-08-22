using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Source String");
            string SourceString, DestinationString=null;
            SourceString = Convert.ToString(Console.ReadLine());
            DestinationString=String.Copy(SourceString);
            Console.WriteLine("The destination string after copying is {0}", DestinationString);
            Console.ReadKey();
        }
    }
}
