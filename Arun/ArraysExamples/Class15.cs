using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            string res = "Welcome to strig concept";
            Console.WriteLine(res); // lower case
            string str = res.ToUpper(); // UPPER CASE
            Console.WriteLine(str);
            Console.WriteLine(res);// lower case

             string[] array =   res.Split(' ');
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine("Array elements are using foreach loop");

            foreach(string s in array)
            {
                Console.WriteLine(s);
            }




        }
    }
}
