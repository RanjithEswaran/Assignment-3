using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyMulidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows, numberOfColumns;
            Console.WriteLine("Enter the row size");
            numberOfRows = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the column size");
            numberOfColumns = Convert.ToInt16(Console.ReadLine());
            int[,] Array = new int[numberOfRows,numberOfColumns];
            int[,] CopyArray = new int[numberOfRows, numberOfColumns];
            Console.WriteLine("Enter the MultiDimensional array elements");
            for(int i=0;i<numberOfRows;i++)
            {
                for( int j=0;j<numberOfColumns;j++)
                {
                    Array[i, j] = Convert.ToInt16(Console.ReadLine());
                    CopyArray[i, j] = Array[i, j];
                }
            }
            Console.WriteLine("The elements in the duplicate array are");
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write("{0} ",CopyArray[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
