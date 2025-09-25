using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A matrix elements : ");
            int[,] a = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter B matrix elements : ");
            int[,] b = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("A matrix elements are");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("B matrix elements are");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }
            int[,]c=new int[2, 2];

            for(int i = 0; i < 2; i++)  // I = 0 0<2
            {
                for(int j = 0;j < 2; j++) // J = 0  0 < 2
                {
                    for(int k = 0;k<2; k++) // K = 0  0<2
                    {
                        c[i,j] = a[i, k] * b[k, j] + c[i,j]; 
                        
                    }
                }
            }
            Console.WriteLine("Multiplication of Array elements");
            for(int i = 0;i < 2; i++)
            {
                for( int j = 0;j< 2; j++)
                {
                    Console.Write($"{c[i,j]}\t");
                }
                Console.WriteLine();
            }


        }
    }
}
