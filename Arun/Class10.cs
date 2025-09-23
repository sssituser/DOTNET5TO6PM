using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine()); // 5
            int start = 1;
            int sum  = 0;
            while (start <= num) // 1<=5 true 2<=5 true 3<=5 true 4<=5 true 5<=5 true 6<=5 false
            {
                Console.WriteLine(start);//1 2 3  4  5
                sum = sum + start;// sum = 0+1=1 sum = 1+2=3 sum = 3+3=6 sum = 6+4=10 sum = 10+5=15
                start++;// 2 3 4 5 
            }
            Console.WriteLine($"Sum is :{sum}");
        }
    }
}
