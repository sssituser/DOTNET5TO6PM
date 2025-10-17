using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Properties
{
    internal class PolyEx
    {
        int a;
        int b;
        public PolyEx()
        {

        }
        public PolyEx(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static PolyEx operator +(PolyEx x, PolyEx y)
        {
            PolyEx s = new PolyEx();
            s.a = x.a + y.a;
            s.b = x.b + y.b;
            return s;

        }
        public void ShowNums()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
        
    }
}
