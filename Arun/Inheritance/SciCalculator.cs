using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    internal class SciCalculator :Calculator
    {
        public void Cos(int num)
        {
            Console.WriteLine(Math.Cos(num));
        }
        public void Sin(int num)
        {
            Console.WriteLine(Math.Sin(num));
        }
    }
}
