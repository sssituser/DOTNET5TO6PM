using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class SplitAndJoin
    {
        /*Split and Join Strings

Problem: Split a sentence into words using Split() and join them back with commas using Join().

Input: "C# is fun" → Output: "C#,is,fun"*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();

            string[] middle = input.Split(' ');

            Console.WriteLine( $"{string.Join(",", middle)}");

        }
    }
}
