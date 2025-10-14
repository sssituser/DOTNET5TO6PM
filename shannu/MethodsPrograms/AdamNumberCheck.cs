using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPrograms
{
    internal class AdamNumberCheck
    {
        public static bool IsAdamNumber(int num)
    {
            int SquareNum = num * num;
            int Rev = Reverse(num);
            int RevSquare = Rev * Rev;
            int SquareOfRev = Reverse(RevSquare);
            return SquareNum == SquareOfRev;
    }

    public static int Reverse(int num)
    {
            int Reverse = 0;
            while (num > 0)
            {
                int temp = num % 10;
                Reverse =Reverse*10+ temp;
                num = num / 10;
            }
            return Reverse;
    }
    



    
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            if(IsAdamNumber(num))
            {
                Console.WriteLine($"Given number is Adam Number i.e {num} and {Reverse(num)}");
            }
            else
            {
                Console.WriteLine("Not an Adam Number");
            }
        }
    }
}
