using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Operator
    {
        int x;
        int y;
        public void show()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
        public void show(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public static Operator operator -(Operator a, Operator b)
        {
            Operator s = new Operator();
            s.x = a.x - b.x;
            s.y = a.y - b.y;
            return s;



        }
    }
}
