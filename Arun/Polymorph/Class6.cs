using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class AA
    {
        protected int a;
        protected int b;
        public void ReadValues()
        {
            Console.Write("Enter a value : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            b = int.Parse(Console.ReadLine());

        }
        public void ShowValues()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
    }
    interface  IB
    {
        void Sum();
        void Sub();
    }
    interface IC 
    {
        void Mul();
        void Div();
    }
    // Fixed: DD now inherits only from AA
    class DD : AA, IB, IC
    {
        public void Div()
        {
            Console.WriteLine($"Quo : {a/b}");
        }

        public void Mul()
        {
            Console.WriteLine($"Mul is :{a * b} ");
        }

        public void Sub()
        {
            Console.WriteLine($"Sub is :{a-b}");
        }

        public void Sum()
        {
            Console.WriteLine($"Sum is :{a + b}");
        }
        public void Remainder()
        {
            Console.WriteLine($"Ream : {a%b}");
        }
    }
    internal class Class6
    {
        static void Main(string[] args)
        {

            

            DD p = new DD();
            p.ReadValues();
            p.ShowValues();
            p.Sum();
            p.Sub();
            p.Mul();
            p.Div();
            p.Remainder ();

                
        }
    }
}
