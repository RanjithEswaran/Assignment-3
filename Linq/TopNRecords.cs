using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopNRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfRecords;
            Console.WriteLine("Enter the number of Records");
            NumberOfRecords = Convert.ToInt16(Console.ReadLine());
            int[] Records = new int[NumberOfRecords];
            Console.WriteLine("Enter the records");
            for(int i=0;i<NumberOfRecords;i++)
            {
                Console.Write("Record {0} : ", i+1);
                Records[i] = Convert.ToInt16(Console.ReadLine());

            }
            Console.WriteLine("Enter the Number of records you want to display");
            int Number = Convert.ToInt16(Console.ReadLine());
            var RequiredRecords = from Record in Records orderby Record descending select Record;
            Console.WriteLine("The top {0} Records are :", Number);
            int j = 1;
            foreach(var Record in RequiredRecords)
            {
                Console.WriteLine("The Records are : {0}", Record);
                j++;
                if (j > Number)
                    break;
            }
            Console.ReadKey();
        }
    }
}
