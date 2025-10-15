using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Student
    {
        int stuid;
        string stuname;
        int stuage;
        string stuemail;
        public Student()
        {
            stuid = 552;
            stuname = "abc";
            stuage = 18;
            stuemail = "abc@gmail.com";
        }
        public Student(int stuid, string stuname, int stuage, string stuemail)
        {
            this.stuid = stuid;
            this.stuname = stuname;
            this.stuage = stuage;
            this.stuemail = stuemail;
        }
        public void GetData()
        {
            Console.WriteLine($"Student Id:{stuid}\n Studnet Name:{stuname}\nStudent Age:{stuage}\nStudent EMail:{stuemail }");
        }
    }
}
