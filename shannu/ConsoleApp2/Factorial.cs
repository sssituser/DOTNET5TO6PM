using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Factorial
    {
        /* Write a Program to find the factorial of the given number
num = 4			Factorial = 1*2*3*4 => Factorial = 24 */

        static void Main(string[] args)
        {
            Console.Write("Enter a Number :");
            int num =int.Parse(Console.ReadLine());

            int Fact = 1;

            for (int i = 1; i <= num; i++) {

               
                Fact = Fact * i;

            }
            Console.WriteLine(Fact);
        }
    }
}
