using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class19
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string :");
            string res = Console.ReadLine();
            int sum = 0;
            string alphas = "abcdefghijklmnopqrstuvwxyz";

            foreach (char ch in res)
            {
                sum += (alphas.IndexOf(ch)+1);
            }
            Console.WriteLine($"{res} score is {sum}");
        }
    }
}
