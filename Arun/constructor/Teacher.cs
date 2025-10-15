using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExmplaes
{
    internal class Teacher
    {
        string name;
        string email;
        string address;
        string subject;
        int salary;
        static Teacher()
        {
            Console.WriteLine("Hi Iam static constructor");
        }
        public Teacher()
        {
            Console.WriteLine("HI Iam constructor without parameters");
            name = "abc";
            email = "abc@gmail.com";
            address = "Hyd";
            subject = ".Net";
            salary = 40000;
        }

        public Teacher(string name,string email,string address,string subject,int salary)
        {
            Console.WriteLine("Hi Iam cons with Parameter");
            this.name = name;
            this.email = email;
            this.address = address;
            this.subject = subject;
            this.salary = salary;

        }
       

        public Teacher(Teacher teacher)
        {
            Console.WriteLine("Hi Iam cons with object as Paramer");
            this.name= teacher.name;
            this.email= teacher.email;
            this.address= teacher.address;
            this.subject = teacher.subject;
            this.salary= teacher.salary;
        }

        ~Teacher()
        {
            Console.WriteLine("object destroyed...");
            Console.ReadLine();
            Console.ReadLine();
        }
        public void ShowTeacher()
        {
            Console.WriteLine($"Name : {name}\nEmail : {email}\nAddress : {address}\nSubject :{subject}\nSalary : {salary}");
        }
    }
}
