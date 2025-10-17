using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Operator obj1 = new Operator();
            obj1.show(10, 20);

            Operator obj2 = new Operator();
            obj2.show(30, 40);


            Operator obj3 = obj1 - obj2;
            obj3.show();
        }
    }
}
