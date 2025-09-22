using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
            /*(Write a program to find the reverse of the given number.
            num = 123       Reverse = 321
    steps:
            form the given number separate the digits num% 10
        % --->Remainder
        / ----->quo
    123 % 10 ===> 3
    123 / 10 ===> 12
    12 % 10 ===> 2
    12 / 10 ====> 1
    1 % 10 ===> 1
    1 / 10 ===> 0)*/


            Console.Write("Enter a Number : ");
            int Num = int.Parse(Console.ReadLine());
            int Rev = 0;

            while(Num > 0)
            {
                int Temp = Num % 10;
                Rev= Rev*10 + Temp;
                Num = Num / 10;
            }
            Console.WriteLine($"Reverse of Given Number is {Rev}");
        }
    }
}
