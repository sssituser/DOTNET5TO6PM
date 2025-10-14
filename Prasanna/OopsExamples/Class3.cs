using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.GetStudInfo(552, "Lucky", "Python");
            stud1.Show();


            Student stud2 = new Student();
            stud2.GetStudInfo(553, "nani", "java");
            stud2.Show();


            Student stud3 = new Student();
            stud3.GetStudInfo(555, "siva", ".Net");
            stud2.Show();
        }
    }
}
