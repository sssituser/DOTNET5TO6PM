using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class16
    {
        static void Main(string[] args)
        {
            string res = "welcome";

            for(int i =  0; i < res.Length; i++)
            {
                Console.WriteLine($"Chracter at {i} index {res[i]}");
            }

            Console.WriteLine("Dispalying the character of given string using mehod");

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"Chracter at {i} index {res.ElementAt(i)}");
            }

            Console.WriteLine(res.Contains("wel"));

            Console.WriteLine(string.IsNullOrEmpty(res));

        }
    }
}
