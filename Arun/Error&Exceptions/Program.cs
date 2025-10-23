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
           
            
            while (true)
            {
                try
                {
                    int a = 0, b = 0;
                    Console.Write("Enter a value : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter b value : ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"a = {a}\t b = {b}");
                    Console.WriteLine($"Quo :{a / b}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter numbers with out decimal values");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("b value can't be zero");
                }
                catch (Exception ex){ // common catch blcok

                   Console.WriteLine($"Error occured....{ex.Message}");
                
                }
                
            }

        }
    }
}
