using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    
    internal class OperatorOverloading
    {
        public int length;
        public int breadth;
        public void Box(int l,int b)
        {
            length = l;
            breadth = b;
        }
        public static OperatorOverloading operator - (OperatorOverloading l,OperatorOverloading b )
        {
            OperatorOverloading o=new OperatorOverloading();
            o.length = b.length-l.length;
            o.breadth = b.breadth-l.length;
            return o;
            
        }
            
            
            

        public int Display( )
        {
            return length * breadth;
        }
        static void Main(string[] args)
        {
            OperatorOverloading obj1 = new OperatorOverloading();
            obj1.Box(10, 20);
            Console.WriteLine(obj1.Display());

            OperatorOverloading obj2 = new OperatorOverloading();
            obj2.Box(50,70);
            Console.WriteLine(obj2.Display());


            OperatorOverloading obj3 = obj1 - obj2;
            Console.WriteLine(obj3.Display());
        }
    }
}
