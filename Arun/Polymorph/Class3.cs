using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Student
    {
        int StuId;
        string StuName;
        int Marks;
        public Student(int StuId,string StuName,int Marks) {
            this.StuId = StuId;
            this.StuName = StuName;
            this.Marks = Marks;
        }
        public void ShowStudent()
        {
            Console.WriteLine($"Student ID : {StuId}\nStudent Name : {StuName}\nStudent Marks : {Marks}");
        }
        public override bool Equals(object obj)
        {
            Student student = (Student)obj;
            Console.WriteLine($"THIS.MARkS {this.Marks}"); // 501
            Console.WriteLine($"Student.MARKS {student.Marks}");//500
            return this.Marks == student.Marks;
           
        }
    }
    internal class Class3
    {

        static void Main(string[] args)
        {
            Student s1 = new Student(111, "Venkat", 500);
            s1.ShowStudent();
            Student s2 = new Student(112, "Prasanna", 500);
            s2.ShowStudent();
            Console.WriteLine(s1.Equals(s2));
            Student s3 = new Student(113, "Shanmuk", 501);
            Console.WriteLine(s3.Equals(s1));
        }
    }
}
