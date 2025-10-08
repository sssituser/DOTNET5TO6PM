using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class SumOfAlphabets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string str = Console.ReadLine();

            String alphas = "abcdefghijklmnopqrstuvwxyz";
            int Sum = 0;

            foreach (char ch in str) {
                Sum += alphas.IndexOf(ch) + 1;
            }

            Console.WriteLine($"Sum of Alphabets : {Sum}");

        }
    }
}
