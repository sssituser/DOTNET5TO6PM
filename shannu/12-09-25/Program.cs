using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of a : ");
           String a = Console.ReadLine();
            
            Console.WriteLine("Enter value of b : ");
            String b = Console.ReadLine();
            


            Console.WriteLine($"sum of a nd b is {a + b}");
            Console.WriteLine("sum of a nd b is " +(a+b));
            Console.WriteLine("sum of a nd b is {0}", (a+b));



            Console.WriteLine("Enter value of x : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y : ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"sum of x and y is {x+y}");
            Console.WriteLine("sum of x nd y is " + (x + y));
            Console.WriteLine("sum of x nd y is {0}", (x+y));


            Console.WriteLine("Enter value of ab : ");
            int ab = Console.Read();
            Console.WriteLine(ab);

            Console.WriteLine("Enter value of bb : ");
            int bb = Console.Read();
            Console.WriteLine(bb);

           





        }
    }
}
