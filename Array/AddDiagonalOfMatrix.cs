using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDiagonalOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column,DiagonalSum=0;
            Console.WriteLine("Enter the number of rows");
            row = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            column = Convert.ToInt16(Console.ReadLine());
            int[,] matrix = new int[row,column];
            Console.WriteLine("Enter the matrix");
            for(int i = 0 ; i < row ; i ++ )
            {
                for(int j = 0 ; j < column ; j ++ )
                {
                    matrix[i, j] = Convert.ToInt16(Console.ReadLine());
                    if (i == j)
                        DiagonalSum += matrix[i, j];
                }
            }
            Console.WriteLine("The sum of the diagonal elements are {0}", DiagonalSum);
            Console.ReadKey();

        }
    }
}
