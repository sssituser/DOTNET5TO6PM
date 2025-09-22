using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStmts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a C# program that asks the user to enter their marks (0–100).
            //Based on the marks, the program should print the grade using the following conditions:
            //90 – 100 → Grade A75 – 89 → Grade B50 – 74 → Grade C,35 – 49 → Grade D,Below 35 → Fail
            Console.WriteLine("Enter Marks: ");
            int A = int.Parse(Console.ReadLine());


            if (A >= 90 && A <= 100)
            {
                Console.WriteLine("Grade A");
            }
            else if (A >= 75)
            {
                Console.WriteLine("Grade B");
            }
            else if (A >= 50)
            {
                Console.WriteLine("Grade C");
            }
            else if (A >= 35)
            {
                Console.WriteLine("Grade D");
            }
            else if (A < 35)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Number must be between 0 -100");
            }
            

        }
    }
}
