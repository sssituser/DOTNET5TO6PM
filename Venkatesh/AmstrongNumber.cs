using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AmstrongNumber
    {
        static void Main(string[] args)
        {
            /*An Armstrong number, also known as a narcissistic number,
              is a number that is equal to the sum of its own digits,
               each raised to the power of the total number of digits in the number,ex. 153=>  1^3 + 5^3 + 3^3 = 153 */


            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int copy = num;

            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine($"==== count is :{count} ====");
            num = copy;
            int sum = 0;
            while(copy>0)
            {
                int digit = copy % 10;
                digit =(int)Math.Pow(digit, count);
                sum = sum + digit;
                copy = copy / 10;
            }
            //Console.WriteLine($"Sum is {sum}");

            if(num==sum)
            {
                Console.WriteLine($"{num} is an Amstrong Number..");
                    
            }
            else
            {
                Console.WriteLine($"{num} is not an Amstrong Number..");
            }
        }
    }
}
