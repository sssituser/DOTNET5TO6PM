using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Finally
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.Write("Enter a Number : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter b number : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Quotiant is : {a / b}");
                }
                catch( Exception e )
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("Vandhe Bharat");
                    Console.WriteLine("\n\n");
                }
                
            }
        }
    }
}
