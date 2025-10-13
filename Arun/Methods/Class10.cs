using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Class10
    {
        public static string GetFebonacci(int num) // 5
        {
            string result = "0  1  ";
            int num1 = 0;
            int num2 = 1;
            for(int i = 1; i < num-1; i++) 
            {
                int sum = num1 + num2; 
                result += sum + "  "; 
                num1 = num2;
                num2 = sum; 
            }
            return result.Trim();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFebonacci(num));
        }
    }
}
