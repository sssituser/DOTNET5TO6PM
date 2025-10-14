using MethodsPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPrograms
{
    internal class PalindromeList
    {
        public static string PalinList(int start, int end) // 10,50
        {
            string res = string.Empty;
            for (int i = start; i <= end; i++)
            {
                if (Program.IsPalindrome(i))
                {
                    res = res + i + ",";
                }
            }
            return res.Substring(0, res.Length - 1) + ".";

        }
        static void Main(string[] args)
        {
            Console.Write("Enter start value : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end value : ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"List of Palindromes : {PalinList(start, end)}");


        }
    }
}