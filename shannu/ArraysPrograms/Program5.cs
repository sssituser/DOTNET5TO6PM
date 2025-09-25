using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPrograms
{
    internal class Program5
    {
        /* Multiplication of Matrices


			1	2	5	6

			3	4	7	8



			1*5+2*7		1*6+2*8
			3*5+4*7		3*6+4*8

			19		22

			43		50 */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A matrix of 2*2");
            int[,] A = new int[2, 2];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter B matrix of 2*2");
            int[,] B = new int[2, 2];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //==============================Dispalying the Matrix A and B=======================================
            Console.WriteLine("Display The Matrix A : ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)

                {
                    Console.Write($"{A[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Display The Matrix B : ");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)

                {
                    Console.Write($"{B[i, j]}\t");
                }
                Console.WriteLine();
            }

            //==============================Multiplication of two Matrices==========================================
            Console.WriteLine("Multiplication of Matrix A and matrix B : ");
            int[,] C= new int[2, 2];
            for(int i = 0;i < A.GetLength(0); i++)
            {
                for(int j = 0;j < B.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0;  k < A.GetLength(1); k++)
                    {
                        sum= sum +( A[i, k] * B[k,j]);
                    }
                    C[i, j] = sum;
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(C[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }

 }
