using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AmstrongNumberCheck
    {
        public static bool IsAmstrong(int num)
        {
            return num == SumOfSquares(num);
        }
        public static int SumOfSquares(int num)
        {
            int copy = num;

            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            //Console.WriteLine($"==== count is :{count} ====");
            //num = copy;
            int sum = 0;
            while (copy > 0)
            {
                int digit = copy % 10;
                digit = (int)Math.Pow(digit, count);
                sum +=  digit;
                copy /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a Number to check : ");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(IsAmstrong(num));

        }
    }
}
