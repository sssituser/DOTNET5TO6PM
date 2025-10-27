using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExamples
{
    internal class Class1
    {
        int StudentId;
        //string StudentName;
       // string StudentEmail;
      //  string StudentClass;
//int StudentNumber;

        public Class1(int studentId)
        {
            StudentId = studentId;
            //StudentName = studentName;
           // StudentEmail = studentEmail;
           // StudentClass = studentClass;
           // StudentNumber = studentNumber;
        }

        public void ShowStudent()
        {
            Console.WriteLine($"Student Id : {StudentId}");
        }
    }
}
