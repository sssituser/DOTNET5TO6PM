using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetData ();
            Console.WriteLine("\n\n");

            Student s2= new Student(553,"Sandhya",19,"sandhya2@gmail.com");
            s2.GetData ();
            Console.WriteLine("\n\n");

            Student s3 = new Student(554, "Ramya", 18, "ramya78@gmail.com");
            s3.GetData();
        }
    }
}
