using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Numbers
    {
        static void Main(string[] args)
        {
            //Printing Numbers from 1 to N.
            Console.Write("Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int start = 1;

            while (num >= start)
            {
                Console.WriteLine(start);
                start++;
            }
        }
    }
}
