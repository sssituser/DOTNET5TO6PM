using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public delegate void Delegates();
    
    class DeleExamples
    {
        int a;
        int b;
        public void Readvalues()
        {
            Console.Write("Enter a value : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            b = int.Parse(Console.ReadLine());

        }
        public void ShowValues()
        {
            Console.WriteLine($"a = {a}\t b = {b}");
        }
        public void Sum()
        {
            Console.WriteLine($"Sum is : {a + b}");
        }
        public void Sub()
        {
            Console.WriteLine($"Sub is : {a - b}");
        }
        public void Mul()
        {
            Console.WriteLine($"Mul is : {a * b}");
        }
    }

    internal class Class6
    {
        static void Main(string[] args)
        {
            DeleExamples d = new DeleExamples();
            Delegates read = new Delegates(d.Readvalues);
            Delegates show = new Delegates(d.ShowValues);
            Delegates d1 = new Delegates(d.Sum);
            Delegates d2 = new Delegates(d.Sub);
            Delegates d3 = new Delegates(d.Mul);
            Delegates d4 = read + show + d1 + d2 + d3;
            d4();
            
        }
    }
}
