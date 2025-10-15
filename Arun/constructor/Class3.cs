using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExmplaes
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teacher 1 Object");
            Teacher teacher1 = new Teacher();
            teacher1.ShowTeacher();
            Console.WriteLine("Teacher 2 Object");
            Teacher teacher2 = new Teacher("kiran","kirankj@gmail.com","Che","java",60000);
            teacher2.ShowTeacher();
            Console.WriteLine("Teacher 3 Object");
            Teacher teacher3 = new Teacher(teacher2);
            teacher3.ShowTeacher();

        }
    }
}
