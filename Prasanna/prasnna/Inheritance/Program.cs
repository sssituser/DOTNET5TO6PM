using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1= new Calculator();
            c1.sum(2, 3);
            c1.sub(5, 3);
            c1.mul(5, 3);
            c1.div(5, 2);
        }
    }
}
