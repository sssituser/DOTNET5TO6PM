using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Scicalculator s1= new Scicalculator();
            s1.sum(2, 3);
            s1.sub(5, 2);
            s1.div(5, 2);
            s1.mul(5, 3);
            s1.sin(90);
            s1.cos(0);
        }
    }
}
