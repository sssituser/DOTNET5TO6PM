using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entera String :");
            String str = Console.ReadLine();

            //==================
            String alphas = "abcdefghijklmnopqrstuvwxyz";
            char[] arr = alphas.ToCharArray();
             Array.Reverse(arr);
            String revAplhas = new String(arr);
            String result = "";

            //===========Encrpytion ====================
            foreach(char c in str.ToLower()) 
            {
               result+= revAplhas[alphas.IndexOf(c)];
            }
            Console.WriteLine(result);
        }
    }
}
