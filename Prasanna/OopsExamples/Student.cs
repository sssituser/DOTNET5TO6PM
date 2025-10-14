using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Student
    {
        public int studid;
        public string studname;
        public string studcourse;
        public void GetStudInfo(int sid, string sname,string scourse)
        {
            studid = sid;
            studname = sname;
            studcourse = scourse;
        }
        public void Show()
        {
            Console.WriteLine($"StudentId:{studid}\nStudentName:{studname}\nStudentCourse:{studcourse}");
        }

    }
}
