using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPrograms
{
    internal class FizzBuzzNum
    {
         public static string GetFizzBuzzNumber(int num)
        {
            string res = string.Empty;

            if (num % 5 == 0 && num %3 == 0)
            {
                res = num + " is a FizzBuzz Number ";
            }
            else
            {
                res = num + " not a FizzBuzz Number";
            }

            return res;
        }
        public static string GetFizzNumber(int num)
        {
            string res1 = string.Empty;

            if (num % 3 == 0)
            {
                res1 = num + " is a Fizz Number ";
            }
            else
            {
                res1 = num + " not a Fizz Number";
            }

            return res1;
        }

        public static string GetBuzzNumber(int num)
    {
        string res2 = string.Empty;
        
            if (num % 5 == 0)
            {
                  res2 = num + " is a Buzz Number "; 
            }
            else
            {
                res2 = num + " not a Buzz Number";
            }
        
        return res2;
    }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Number {i}");
                Console.WriteLine(GetBuzzNumber(i));
                Console.WriteLine(GetFizzBuzzNumber(i));
                Console.WriteLine(GetFizzNumber(i));
                Console.WriteLine();
            }
        }
    }
}
