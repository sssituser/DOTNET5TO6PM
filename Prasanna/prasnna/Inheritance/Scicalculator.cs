using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Scicalculator:Calculator 
    {
        public void sin(int num)
        {
            Console.WriteLine(Math.Sin(num));
        }
        public void cos(int num)
        {
            Console.WriteLine(Math.Cos(num));
        
        }
    }
}
