using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class CharFrequency
    {
        /* Count Character Frequency

Problem: Count frequency of each character in a string.

Input: "hello" → Output:

h = 1
e = 1
l = 2
o = 1*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string Input = Console.ReadLine();

            int Output = 1;

            foreach (char c in Input) {
                
                Output = Input.IndexOf(c) ;

                
                
                    Console.WriteLine($"{c} ->{Output} ");
                
               
            }
            Console.WriteLine(Output);
        }
    }
}
