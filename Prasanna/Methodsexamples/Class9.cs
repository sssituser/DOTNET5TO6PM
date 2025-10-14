using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class9
    {
        public static string PalinList(int start,int end)
        {
            string res = string.Empty;
            for (int i = start; i <= end; i++)
            {
                if (Class1.IsPalindrome(i))
                {
                    res = res + i + ",";
                }
            }
            return res.Substring(0, res.Length - 1) + ".";
        }
        public static string AdamList(int start, int end)
        {
            string res = string.Empty;
            for (int i = start; i <= end; i++)
            {
                if (Class3.IsAdam(i))
                {
                    res = res + i + ",";
                }
            }
            return res.Substring(0, res.Length - 1) + ".";
        }
        public static string Perfectlist(int start, int end)
        {
            string res = string.Empty;
            for (int i = start; i <= end; i++)
            {
                if (Class5.IsPerfect(i))
                {
                    res = res + i + ",";
                }
            }
            return res.Substring(0, res.Length - 1) + ".";
        }
        public static bool IsArmstrong(int num)
        {
            int temp = num;
            int sum = 0;
            int digits = 0;
            int n = num;
            while (n > 0)
            {
                digits++;
                n /= 10;
            }
            temp = num;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }
            return sum == num;
        }
        public static string ArmstrongList(int start, int end)
        {
            string result = string.Empty;
            for (int i = start; i <= end; i++)
            {
                if (IsArmstrong(i))
                {
                    result += i + ",";
                }
            }
            return result.Substring(0, result.Length - 1) + ".";
        }

        public static void Main(string[] args)
            {
                Console.WriteLine("enter start value");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("enter end value");
                int end = int.Parse(Console.ReadLine());
                Console.WriteLine($"List Of Palindromes {PalinList(start, end)}");
                Console.WriteLine($"List of Adam numbers {AdamList(start, end)}");
                Console.WriteLine($"List Of Perfect Numbers {Perfectlist(start, end)}");
                Console.WriteLine($"List Of Armstrong Numbers {ArmstrongList(start, end)}");
            }
        }
    }

