using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignments
{
    internal class DiagonalMatrix
    {
        /*Write a program to read elements for rectangular array of size 3
        display the diagonal elements.*/


        static void Main(string[] args)
        {
            Console.Write("Enter Row size : ");
            int row =int.Parse(Console.ReadLine());

            Console.Write("Enter column size : ");
            int col = int.Parse(Console.ReadLine()); 
            
            int[,] matrix= new int[row,col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i,j]=int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            //Console.WriteLine();

            for(int i = 0; i < row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }
            //Console.WriteLine();


            if (row == col)
            {
                Console.WriteLine("Diagonal elements are : ");

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (i == j || i+j==col-1)
                        {
                            Console.Write($"{matrix[i, j]}\t");
                        }
                        else
                        {
                            Console.Write("\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("To get Diagonal elements --> row and column size should be equal!!!");
                Console.WriteLine();
            }

        }

    }


}
