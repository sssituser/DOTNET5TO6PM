using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class PolyEx
    {
        int x;
        int y;
        public void show()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
        public  void show(int x, int y)
        {
            this.x = x;
            this.y = y;
            
        }
        public static PolyEx operator+(PolyEx a, PolyEx b)
        {
            PolyEx s = new PolyEx();
            s.x = a.x + b.x;
            s.y = a.y + b.y ;
            return s;



        }
    }
}
