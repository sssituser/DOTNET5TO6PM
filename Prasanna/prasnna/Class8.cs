using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class8
    {
        public static string StrongNumlist(int start, int end)
        {
            string res = string.Empty;
            for (int i = start; i <= end; i++)
            {
                if (Class7.IsStrong(i))
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
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"List Of Strong Numbers {StrongNumlist(start, end)}");
        }
    }
}