using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    
    internal class Class1
    {
        public static bool IsPalindrome(int num)
        {
            return num == Reverse(num);
        }
        public static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num=int.Parse(Console.ReadLine());
            if(IsPalindrome(num))
            {
                Console.WriteLine($"given number {num} is palindrome");
            }
            else
            {
                Console.WriteLine($"given number {num} is not palindrome");
            }
        }
    }
}
