using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class2
    {
        public static string PalinList(int start,int end)
        {
            string res = string.Empty;
            for(int i =start;i<=end;i++)
            {
                if(Class1.IsPalindrome(i))
                {
                    res = res + i + ",";
                }    
            }
            return res.Substring(0, res.Length - 1) + ".";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter start value");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter end value");
            int end = int.Parse (Console.ReadLine());
            Console.Write($"List Of Palindromes :{PalinList(start,end)}");
        }
    }
}
