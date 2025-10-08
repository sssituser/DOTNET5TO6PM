using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class6
    {
        public static string Perfectlist(int start,int end)
        {
            string res = string.Empty;
            for(int i= start;i<=end;i++)
            {
                if(Class5.IsPerfect(i))
                {
                    res = res + i + ",";
                }
            }
            return res.Substring(0, res.Length - 1)+".";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter start value");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter end value");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"List of Perfect numbers {Perfectlist(start, end)}");
        }
    }
}
