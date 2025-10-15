using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Employee e1= new Employee();
            e1.Getshow();
            Console.WriteLine("\n\n");


            Employee e2= new Employee(112,"nani",20000);
            e2.Getshow();
            Console.WriteLine("\n\n");


            Employee e3 = new Employee(113,"Lucky",30000);
            e3.Getshow();
            Console.WriteLine("\n\n");


            Employee e4 = new Employee(114, "Honey", 40000);
            e4.Getshow();
            Console.WriteLine("\n\n");


            Employee e5 = new Employee(115, "Chinnu", 50000);
            e5.Getshow ();
            Console.WriteLine("\n\n");
        }
    }
}
