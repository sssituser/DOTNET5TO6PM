using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamples
{
    internal class Class1
    {
        int StudId;
        string StuName;
        int StuRollNo;
        string StuClass;

        public Class1()
        {

        }

        public Class1(int StudId, string StuName, int StuRollNo)
        {
            this.StudId = StudId;
            this.StuName = StuName;
            this.StuRollNo = StuRollNo;
        }
        public Class1(int StudId, string StuName, string StuClass)
        {
            this.StudId = StudId;
            this.StuName = StuName;
            this.StuClass = StuClass;
        }

        public Class1(int StudId, string StuName)
        {
            this.StudId = StudId;
            this.StuName = StuName;
         
        }


        public void GetStudentDetails()
        {
            if(StudId!=0)
            {
                Console.WriteLine($"Student Id : {StudId}");
            }
            if (!string.IsNullOrEmpty(StuName)
)
            {
                Console.WriteLine($"Student Name : {StuName}");
            }
            if (StuRollNo != 0)
            {
                Console.WriteLine($"Student Roll Number : {StuRollNo}");
            }
            if(!string.IsNullOrEmpty(StuClass)
)
            {
                Console.WriteLine($"Student Class : {StuClass}");
            }
           
        }
    }
}
