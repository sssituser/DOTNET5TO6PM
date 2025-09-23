using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PalinCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num=Convert.ToInt32(Console.ReadLine()); // num = 123
            int originalnum = num;          // originalnum = 123
            int reverse = 0;              // reverse = 0
            while (num > 0)  // 123 > 0 12>0  1>0 0>0
            {
                int ld = num % 10; // ld = 123%10 = 3  ld = 12%10 = 2 ld = 1%10 = 1
                reverse = reverse * 10 + ld;//  reverse = 0*10+3 = 3 reverse = 3*10+2=32  reverse = 32*10+1=321
                num = num / 10;// num = 123/10 = 12  12/10 = 1   1/10=0

            }
            // 123   == 321 False
            if (originalnum==reverse)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }

        }
    }
}
