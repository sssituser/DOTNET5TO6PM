using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            while (true)
            {
                try
                {
                    
                    Console.WriteLine("Enter a Value : ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter b Value : ");
                    b = int.Parse(Console.ReadLine());

                    
                    if(b == 0)
                    {
                        throw new Exception("No Zeros allowed ");
                    }
                    int c = a / b;
                    Console.WriteLine($"Result : {c}");
                }
                //catch(DivideByZeroException e)
                //{
                //    Console.WriteLine($"b Shoul not be Zero !!!!!!!!! \n {e.Message}");
                //}
                catch(FormatException e)
                {
                    Console.WriteLine($"Please enter only Numbers (NO STRINGS ALLOWED) \n {e.Message}");
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Error : {e.Message}\n{e.ToString()}");
                }
                finally
                {
                    Console.WriteLine("Execute Common Ouput");

                    Console.WriteLine();
                }
            }
        }
    }
}
