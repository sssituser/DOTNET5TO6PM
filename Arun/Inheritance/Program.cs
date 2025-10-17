using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Sum(4, 5);
            calculator.Sub(6, 2);
            calculator.Mul(5, 3);
            calculator.Div(6, 4);

        }
    }
}
