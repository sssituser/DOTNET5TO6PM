using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ArraysMultiplication
    {
        //Multiplication of Matrices.
        //Note: The number of columns in A must equal the number of rows in B.
        static void Main(string[] args)
        {
            Console.Write("Enter a's row size : ");
            int arow = int.Parse(Console.ReadLine());
            Console.Write("Enter a's Column size : ");
            int acol=int.Parse(Console.ReadLine());

            int[,] a= new int[arow, acol];
            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < arow; i++)
            {
                for (int j = 0;j<acol;j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix a is : ");
            Console.WriteLine();
            for(int i = 0; i < arow; i++)
            {
                for(int j=0;j<acol;j++)
                {
                     Console.Write($"{a[i,j]}\t");

                }
                Console.WriteLine("\n\n");
            }

            
            Console.Write("Enter Column size : ");
            int bcol = int.Parse(Console.ReadLine());

            int[,] b = new int[acol, bcol];
            Console.WriteLine("Enter b array elements : ");

            for (int i = 0; i < acol; i++)
            {
                for (int j = 0; j < bcol; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix b is : ");

            Console.WriteLine();
            for (int i = 0; i < acol; i++)
            {
                for (int j = 0; j < bcol; j++)
                {
                    Console.Write($"{b[i, j]}\t");

                }
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("Matrix multiplication : ");
            Console.WriteLine();
            int[,] c = new int[arow, bcol];
            for ( int i = 0;i<arow;i++)
            {
                for(int j=0;j<bcol;j++)
                {
                    
                    for (int k = 0; k < acol; k++)
                    {
                       c[i,j] = a[i, k] * b[k, j] + c[i,j];
                    }
                }
                Console.WriteLine();
            }
            for(int i = 0;i<arow;i++)
            {
                for(int j = 0;j<bcol;j++)
                {
                    Console.Write($"{c[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
