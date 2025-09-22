using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
			/* Write a program to check given number is Palindrome or not?


	What is Palindrome ? Number and Its Reverse number if both are equal then number is said to
	be palindrome.


	Example: num = 456
		 reverse = 654

		456 != 654
	

	num = 456		ld = num%10 => ld = 6


	654
	num = num/10 ===>  num = 45 % 10  = 5
	num = 45 /10 ==>   num = 4%10    ld = 4 */

			Console.Write("Enter a Number : ");
			int Palin = int.Parse(Console.ReadLine());
			int Original = Palin;
			int Rev = 0;

			while (Palin>0)
			{
				int Temp = Palin % 10;
				Rev = Rev *10 + Temp;
				Palin =Palin / 10;
			}
            if (Original == Rev)
            {
                Console.WriteLine($"Given Number {Original} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"Given Number {Original} is NOT a Palindrome");
            }
        }
    }
}
