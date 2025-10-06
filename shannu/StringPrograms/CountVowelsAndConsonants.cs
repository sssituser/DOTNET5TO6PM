using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class CountVowelsAndConsonants
    {
        /*Count Vowels and Consonants

Problem: Count vowels(a, e, i, o, u) and consonants in a string.

Input: "OpenAI" → Output: Vowels = 3, Consonants = 3*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string Input = Console.ReadLine().ToLower();

            int CountVowels = 0;
            int CountConsonants = 0;

            string Alphas = "abcdefghijklmnopqrstuvwxyz";
            char[] ch = { 'a', 'e', 'i', 'o', 'u' };

            Console.Write("Vowels Count is : ");
            foreach (char c in Input) 
            {
                if (Alphas.Contains(c))
                {
                    if (ch.Contains(c))
                    {
                        CountVowels++;
                    }
                    else
                    {
                        CountConsonants++;
                    }
                }
            }
            Console.WriteLine(CountVowels);

            Console.Write("Consonants Count is : ");
            
            Console.WriteLine(CountConsonants);
        }
    }
}
//'a','e','i','o','u'