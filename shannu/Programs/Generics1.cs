using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{

    class Student
    {
        int StudentId;
        string StudentName;
        int StudentAge;

        public Student() { }
        public Student(int studentId, string studentName,int StudentAge)
        {
            StudentId = studentId;
            StudentName = studentName;
            this.StudentAge=StudentAge;
        }

        public override string ToString()
        {
            return $"STudent ID : {StudentId}\t Student Name ; {StudentName}\t Student Age : {StudentAge}";
        }
    }
    class Employeee<T,D>
    {
        int a;
        string b;
        
        public Employeee() { }
        public Employeee(int a,string b)
        {
            this.a = a;
            this.b = b;
        }
        //public void getInfo()
        //{
        //    Console.WriteLine("Enter a value: ");
        //    a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter a value:");
        //    b = Console.ReadLine();
        //}
        public void ShowInfo(T a , D b)
        {
            Console.WriteLine($"t={a}\t d={b}");
        }
    }

    class EMP<T>
    {
        public void Show(T a,T x)
        {
            Console.WriteLine($"{a}\n{x}");
        }
    }
    internal class Generics1
    {
        static void Main(string[] args)
        {
            Employeee<int,string> emp = new Employeee<int,string>();
            //emp.getInfo();
            emp.ShowInfo(4,"shannu");


            EMP<Student> e = new EMP<Student>();
            e.Show(new Student(12, "shannu", 23), new Student(31, "kiran", 36));

        }
    }
}
