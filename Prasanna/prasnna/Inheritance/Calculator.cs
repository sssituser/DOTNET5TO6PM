using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Calculator
    {
        public void sum(int a,int b)
        {
            Console.WriteLine($"Sum of A and B :{a+b}");
        }
        public void sub(int a ,int b)
        {
            Console.WriteLine($"Sub of A and B :{a-b} ");
        }
        public void mul(int a ,int b)
        {
            Console.WriteLine($"Mul of A and B :{a*b}");
        }
        public void div(int a ,int b)
        {
            Console.WriteLine($"Division of A and B :{a/b}");
        }
    }
}
