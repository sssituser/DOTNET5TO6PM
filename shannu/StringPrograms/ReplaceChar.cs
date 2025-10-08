using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class ReplaceChar
    {
        /*Replace Characters

Problem: Replace all occurrences of a character in a string using Replace().

Input: "programming", replace "a" with "@" → Output: "progr@mming"
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string input = Console.ReadLine();

            if (input.Contains('a'))
            {
                string output = input.Replace('a', '@');
                Console.WriteLine(output);
            }
            
        }
    }
}
