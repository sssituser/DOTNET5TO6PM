using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String:");
            string str = Console.ReadLine();

            Console.Write("Enter an Integer : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Float value : ");
            float f = float.Parse(Console.ReadLine());


            Console.Write("Enter a double value : ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter  a boolean value : ");
            bool b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"str : {str}\na : {a}\nf = {f}\nd : {d}\nb : {b}");
        }
    }
}
