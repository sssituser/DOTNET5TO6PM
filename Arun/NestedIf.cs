using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NestedIf
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Temparature : ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp > 20)
            {
                if(temp > 30)
                {
                    Console.WriteLine("Too Hot....");
                }
                else
                {
                    Console.WriteLine("Hot....");
                }
            }
            else {

                Console.WriteLine("Cool....");
            
            }
        }
    }
}
