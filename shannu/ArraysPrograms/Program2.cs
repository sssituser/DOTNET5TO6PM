using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPrograms
{
    internal class Program2
    {
        /* Write program to read 5 names of the students,
and read three subjects marks of student and display the 
name marks and total marks. */
        static void Main(string[] args)
        {
            string[] Str = new string[5];
            Console.WriteLine("Name of Students : ");

            

            for (int i = 0; i < 5; i++) {
                Str[i] = Console.ReadLine();
            }

            int[,] Marks = new int[5, 3];
            Console.WriteLine("Marks of each Student : ");

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 3; j++)
                {
                    Marks[i,j]= int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            //Display Results
            Console.WriteLine("Dispalying the results : ");
            Console.WriteLine("Name\tSubject1\tSubject2\tSubject3\tTotalMarks\t");

            for (int i = 0; i < 5; i++)
            {
                int total = 0;
                Console.Write($"{Str[i]}\t");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{Marks[i, j]}\t\t");
                    total =total +  Marks[i, j];
                }

                Console.WriteLine($"{total}");
            }
        }
    }
}
