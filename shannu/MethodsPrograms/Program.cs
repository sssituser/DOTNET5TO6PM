using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPrograms
{
    internal class Program
    {

        public static bool IsPalindrome(int num)
        {
            
                return num == Reverse(num);
        }
        
        public static int Reverse(int num)
        {
            int rev = 0;
            while(num > 0)
            {
                int temp  = num % 10;
                rev  = rev*10 + temp;
                num /= 10;
            }
            return rev;
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            if (IsPalindrome(num))
            {
                Console.WriteLine($"Given number is Palindrome i.e {num} and {Reverse(num)}");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }
    }
}
