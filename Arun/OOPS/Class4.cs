using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Student.SetValues(111, "abc", "abc@gmail.com");
            //Student.ShowValues();
            Console.WriteLine(Student.sId);
            Console.WriteLine(Student.sName);
            Console.WriteLine(Student.sEmail);
           }
    }
}
