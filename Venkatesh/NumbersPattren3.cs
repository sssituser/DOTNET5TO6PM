using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class NumbersPattren3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num =int.Parse(Console.ReadLine());


            int x = 1;
            for(int i = 1;i<=num;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(x + "\t");
                    x++;
                }
             Console.WriteLine();
            }
        }
    }
}
