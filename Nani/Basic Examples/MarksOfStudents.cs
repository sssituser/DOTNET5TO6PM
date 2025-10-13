using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MarksOfStudents
    {
       /* 1.Write program to read 5 names of the students,
           and read three subjects marks of student and display the
            name marks and total marks.     

            kiran  45	55	66
            Raj    38       60      77 */
        static void Main(string[] args)
        {
            int[] total = new int[5];
            
            string[] students = new string[5];
            Console.WriteLine("Enter student Names : ");

            for(int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();

            }

            int[,] marks = new int[5, 3];
            Console.WriteLine("Enter Marks of the students : ");
            for (int i = 0; i < 5; i++)
            {
                total[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    
                    marks[i, j] = int.Parse(Console.ReadLine());
                    total[i] += marks[i,j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("List of the students");
            for(int i = 0;i < students.Length; i++)
            {
                Console.Write($"{students[i]}\t");
            }
            Console.WriteLine();
            for(int i = 0;i<5;i++)
            {
                Console.Write($"{students[i]}:");
                for (int j = 0; j < 3; j++)
                {


                    Console.Write($"Subject{j+1}:{marks[i, j]}\t");
                }
                Console.Write($"Total: {total[i]}");
                Console.WriteLine();
                    

            }



        }
    }
}
