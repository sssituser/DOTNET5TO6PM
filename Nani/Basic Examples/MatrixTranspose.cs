using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MatrixTranspose
    {
        /* Write program to read elements for the array of size 2x3
         and display them find the transpose of the matrix.*/


        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 3];
            Console.WriteLine("Enter Matrix elements");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();

            }
            Console.WriteLine("Matrix before inverse :: ");

            for(int i=0;i<2;i++)
            {
                for (int j=0;j<3; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("Inverse of the matrix\transpose");
            for(int i=0;i<3; i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write($"{matrix[j,i]}\t");
                }
                Console.WriteLine("\n\n");  
            }
        }

    }
}
