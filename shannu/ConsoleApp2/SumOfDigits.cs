using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SumOfDigits
    {
        /* Write a Program to find sum of   n numbers
n = 5		sum = 1+2+3+4+5  sum = 15 */

        static void Main(string[] args)
        {
            Console.Write("Enter any Number : ");
            int a =int.Parse(Console.ReadLine());

            int sum = 0;
            for (int n = 1; n <= a; n++) {

                sum = sum + n;
            
            }
            Console.WriteLine($"Sum of N Numbers {sum}");


        }
    }
}
