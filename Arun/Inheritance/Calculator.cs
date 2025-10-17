using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    internal class Calculator
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine($"sum of and b is {a+b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"sub of and b is {a - b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"mul of and b is {a * b}");
        }
        public void Div(int a, int b)
        {
            Console.WriteLine($"quo of and b is {a / b}");
        }
    }
}
