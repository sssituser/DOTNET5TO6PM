using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    internal class Student
    {
        public static int sId;
        public static string sName;
        public static string sEmail;
        public static void SetValues(int sid,string sname,string semail)
        {
          sId = sid;
          sName = sname;
          sEmail = semail;
        }
        public static void ShowValues()
        {
            Console.WriteLine($"{sId}\t{sName}\t{sEmail}");
        }
    }
}
