using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPrograms
{
    internal class Program6
    {
        /* Write a program to read elements for rectangular array of size 3
display the diagonal elements. */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A matrix of m*n");
            int[,] A = new int[3, 3];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Display MAtrix and Diagonal Elements
            Console.WriteLine("A matrix");
            for (int i=0;i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    
                    Console.Write($"{A[i,j]}\t");
                    
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Diagonal elements in matrix are : ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {

                    if (i == j)
                    {
                        
                        Console.WriteLine($"{A[i, j]}\t");
                    }
                }
            }

        }

    }
}
