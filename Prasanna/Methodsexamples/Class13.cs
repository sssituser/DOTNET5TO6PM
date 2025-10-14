using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class13
    {
        public static int GetFibNth(int num)
        {
            string res = string.Empty;
            res = "0  1  ";
            int sum = 0;
            int num1 = 0;
            int num2 = 1;
            for (int i = 1; i <= num - 2; i++)
            {
                sum = num1 + num2;
                res += sum + "  ";
                num1 = num2;
                num2 = sum;
            }
            return num2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibNth(num));

        }
    }
}