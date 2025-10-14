using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 student1 = new Class1(11,"shannu",32);
            Class1 Student2 = new Class1(112, "Swathi", "Maths");
            Class1 Student3 = new Class1(22, "Yuvaraj");
            Class2 Teacher1 = new Class2("abc", "Male", 15);
            Class2 Teacher2 = new Class2("efg", "Female", 25);
            student1.GetStudentDetails();
            Console.WriteLine();
            Student2.GetStudentDetails();
            Console.WriteLine();
            Student3.GetStudentDetails();
            Console.WriteLine();
            Teacher1.GetTeacherDetails();
            Console.WriteLine();
            Teacher2.GetTeacherDetails();
        }
    }
}
