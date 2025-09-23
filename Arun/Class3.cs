using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());   
            int rev = 0;
            while (num > 0)//123>0 T, 12>0 T, 1>0 T, 0>0 F
            {
                int ld = num%10; //123%10=3, 12%10=2, 1%10=1
                rev = rev * 10 + ld; //0*10+3=3, 3*10+2=32, 32*10+1=321
                num = num / 10; //123/10=12, 12/10=1, 1/10=0
            }
            Console.WriteLine($"Revser number is {rev}");
        }
    }
}
