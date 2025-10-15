using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExmplaes
{
    internal class Student
    {
        int stuId;
        string stuName;
        int marks;

        public Student()
        {
        }

        public Student(int stuId, string stuName, int marks)
        {
            this.stuId = stuId;
            this.stuName = stuName;
            this.marks = marks;
        }
        public void ShowStuent()
        {
            Console.WriteLine($"Student Id :{stuId}\nStudent Name : {stuName}\nMarks : {marks}");
        }
    }
}
