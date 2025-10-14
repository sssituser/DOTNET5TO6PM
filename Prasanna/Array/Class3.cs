using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            string[] student = new string[5];
            for(int i =0; i < 5;i++)
            {
                student[i] = Console.ReadLine();

            }
            foreach (string  i in student )
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            int[,] marks = new int[5, 3];
            for(int i = 0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    marks[i,j]=int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("subject marks");
            for(int i = 0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write($"{marks[i, j]}\t");

                }
                Console.WriteLine ();
            }

        }
    }
}
