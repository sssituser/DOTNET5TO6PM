using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPrograms
{
    internal class Program7
    {
        /*Write program to read elements for the array of size 2x3
and display them find the transpose of the matrix.*/
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter num of rows : ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num of columns : ");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Matrix of m*n");
            int[,] A = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //================================================
            Console.WriteLine("Display the matrix m*n :");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{A[i,j]}\t");
                }
                Console.WriteLine();
            }
            //==============Transpose of MAtrix=====================
            Console.WriteLine("Transpose of matrix : ");
            for(int i = 0;i < columns; i++)
            {
                for(int j = 0;j < rows; j++)
                {
                    Console.Write($"{A[j,i]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
