using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class CommonCatch
    {
        static void Main(string[] args)
        {


            while (true)
            {
                try
                {
                    Console.Write("Enter a Number : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter B Number : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Remainder is : {a % b}\n");
                }



                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
