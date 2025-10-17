using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Teacher
    {
        string Name;
        string Email;
        string Subject;
        string Address;
        int Salary;
        public Teacher ()
        {
            Name = "Lakshmi";
            Email = "lakshmi45@gmail.com";
            Subject = "Dot Net";
            Address = "Hyderabad";
            Salary = 30000;

        }
        public Teacher(string name, string email, string subject, string address, int salary)
        {
            Name = name;
            Email = email;
            Subject = subject;
            Address = address;
            Salary = salary;
        }
        public Teacher(Teacher teacher)
        {
            Name = teacher.Name;
            Email = teacher.Email;
            Subject= teacher.Subject;
            Address = teacher.Address;
            Salary = teacher.Salary;
        }
        public  void ShowTeacher()
        {
            Console.WriteLine($"Teacher Name:{Name}\nTeacher Email:{Name}\n Teacher Subject:{Subject}\n Teacher Address:{Address}\n Teacher Salary:{Salary}");
        }
    }
}
