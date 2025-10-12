using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Fabonacciseries
    {
        public static string GetFebonacciList(int num)//0   1   1   2   3   5
        {
            string list = "0    1   ";
            int num1 = 0;
            int num2 = 1;
            int sum = 0;
            for(int i=1;i<num-1;i++)
            {
                
                sum = num1 + num2;
                list += sum + "    ";
                num1 = num2;    //1,1
                num2 = sum;     //1,2
            }
            return list;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(GetFebonacciList(num));

             
        }
    }
}
