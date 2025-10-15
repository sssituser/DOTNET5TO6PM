using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Patient p1= new Patient();
            p1.GetData();
            Console.WriteLine("\n\n");

            Patient p2= new Patient(101,"Divya","Dengue",26);
            p2.GetData();
            Console.WriteLine("\n\n");

            Patient p3= new Patient(102,"Ramya","Malaria",22);
            p3.GetData();
            Console.WriteLine("\n\n");

            Patient p4= new Patient(103,"Kavya","Cold",15);
            p4.GetData ();
            Console.WriteLine("\n\n");
        }
    }
}
