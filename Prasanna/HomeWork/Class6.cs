using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Teacher t1=new Teacher ();
            t1.ShowTeacher();
            Console.WriteLine("\n\n");
            Teacher t2=new Teacher ("Prasanna","prasanna765@gmail.com","Python","Chennai",40000);
            t2.ShowTeacher();
            Console.WriteLine("\n\n");
            Teacher t3 = new Teacher(t2);
            t3.ShowTeacher();
        }
    }
}
