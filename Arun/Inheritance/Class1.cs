using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            SciCalculator scicalcy = new SciCalculator();
            scicalcy.Sum(4, 5);
            scicalcy.Sub(5, 2);
            scicalcy.Mul(3, 4);
            scicalcy.Div(5, 2);
            scicalcy.Sin(90);
            scicalcy.Cos(45);
           
            
        }
    }
}
