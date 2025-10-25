using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class IndividualCatch
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.Write("Enter a number : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter b number : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Remainder is : {a % b}\n");

                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter integer numbers only");
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("b value connot be Zero,,Try with another numbers except zero");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("You have entered a large value , Try with some less value");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
