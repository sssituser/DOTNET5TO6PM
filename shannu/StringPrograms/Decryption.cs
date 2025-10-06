using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class Decryption
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            String str = Console.ReadLine();

            //====================================
            string alphas = "abcdefghijklmnopqrstuvwxyz";
            //Console.WriteLine(alphas);
            char[] ch = alphas.ToCharArray();
            Array.Reverse(ch);
            string revAlphas = new string(ch);
            //Console.WriteLine(revAlphas);
            string result = "";
            //===========Decryption===================

            foreach(char c in str.ToLower())
            {
                result += alphas.ElementAt(revAlphas.IndexOf(c));
            }
            Console.WriteLine(result);
        }
    }
}
