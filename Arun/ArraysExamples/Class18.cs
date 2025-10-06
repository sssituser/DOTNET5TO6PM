using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class18
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string :");
            string str = Console.ReadLine(); //abc
            string res = string.Empty; 
            string alphas = "abcdefghijklmnopqrstuvwxyz";
            string ralphas= "zyxwvutsrqponmlkjihgfedcba";
          
            foreach(char ch in str) // abc
            {
              res += ralphas.ElementAt(alphas.IndexOf(ch));
            }

            Console.WriteLine($"{str} Encryption is {res}");



        }
    }
}
