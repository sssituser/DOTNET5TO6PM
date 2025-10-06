using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class ContainsSubstring
    {
        /*Check if String Contains a Substring

Problem: Ask user for a string and a substring, and check if the substring exists using Contains().

Input: "hello world", substring "lo" → Output: "Substring exists"*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string :");
            string input = Console.ReadLine();

            Console.WriteLine("Enter a substring");
             string subString = Console.ReadLine();

            if (input.Contains(subString))
            {
                Console.WriteLine("Substring exists");
            }
            else
                Console.WriteLine("Substring does not exist");
        }
    }
}
