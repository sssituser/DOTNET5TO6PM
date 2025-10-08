using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class Palindrome
    {
        /*Check Palindrome

Problem: Check if a string is a palindrome(reads the same forwards and backwards).

Input: "madam" → Output: "Palindrome"

Input: "hello" → Output: "Not Palindrome"*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string input = Console.ReadLine().ToLower();
            
            //========================
            Console.WriteLine("Display the given String into Char");
            foreach(char c in input)
            {
                Console.Write($"{c}\t");
            }
            Console.WriteLine();

            char[]  ch= input.ToCharArray();
            Array.Reverse(ch);
            string Output = new string(ch);

            Console.WriteLine(Output);


            //=================================
            Console.WriteLine("Check Palindrome or not ");
            if(input == Output)
            {
                Console.WriteLine("Given Input is Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
