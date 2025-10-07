using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Class1
    {
        public static bool IsPalindrome(int num) // num = 121
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
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if (IsPalindrome(num))
            {
                Console.WriteLine($"given num {num} is Palidrome");
            }
            else
            {
                Console.WriteLine($"Given num {num} is not a Palindrome");
            }
        }
    }

}