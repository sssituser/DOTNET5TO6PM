using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Class11
    {
        // 0 1 1 2 3 5 8 13
        public static int GetNthFebo(int index) // 5
        {
            string res = "0  1  ";
            int num1 = 0;
            int num2 = 1;
            for(int i = 1; i < index-1; i++) // i=1 1<=5  i=2 2<=5 i=3<=5 i=4<=5 5<=5 6<=5
            {
                int sum = num1 + num2; //0 1  1  2  3  5  8
                res += sum + "  "; // res = 0  1   1  2  3  
                num1 = num2; // 1 2 3 5
                num2 = sum; // 2  3 5 8
            }
            
            return num2;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter index of Febo :");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(GetNthFebo(index));
        }
    }
}
