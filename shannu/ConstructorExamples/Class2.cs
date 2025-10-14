using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamples
{
    internal class Class2
    {
        string TeacherName;
        string TeacherGender;
        int TeacherAge;

        public Class2(string teacherName, string teacherGender, int teacherAge)
        {
            TeacherName = teacherName;
            TeacherGender = teacherGender;
            TeacherAge = teacherAge;
        }

        public void GetTeacherDetails()
        {
            Console.WriteLine($"Teacher Name : {TeacherName}\nTeacher Gender : {TeacherGender}\nTeacher Age : {TeacherAge}");
        }
    }
}
