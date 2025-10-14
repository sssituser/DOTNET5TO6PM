using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPrograms
{
    internal class fibonacciseries
    {
        public static string GetFibonacci(int num)
        {
            string res = string.Empty;
            int num1 = 0;
            int num2 = 1;
            for(int i = 0; i < num-1; i++)
            {
                int output = num1 +num2;
                res  += output +" ";
                num1 = num2;
                num2 = output;
            }
            return $"{ 0 } { 1 } { res}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter anumber : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(num));
        }



    }
}
