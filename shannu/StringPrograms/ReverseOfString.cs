using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class ReverseOfString
    {
        /*Problem: Write a program to reverse a string entered by the user using ToCharArray() and Array.Reverse().

Input: "hello"

Output: "olleh"*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            String input = Console.ReadLine();

            foreach(char c in input)
            {
                Console.WriteLine(c);
            }

           char[] ch= input.ToCharArray();
             Array.Reverse(ch);

            string output = new string(ch);

            Console.WriteLine($"{output}");
        }
    }
}
