using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            PolyEx p1= new PolyEx();
            p1.show(10,20);
            
            PolyEx p2= new PolyEx();
            p2.show(30,40);

            
            PolyEx p3 = p1 + p2;
            p3.show();
        }
    }
}
