using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ThrowExample
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.Write("Enter a value : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter b value : ");
                    int b = int.Parse(Console.ReadLine());
                    if(b==0)
                    {
                        throw new DivideByZeroException();
                    }
                    Console.WriteLine($"Quotiant is : {a/b}");

                }
               
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Anthaaa... assam !!!");
                }
            }
        }
    }
}
