using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Bank
    {
        int accnum;
        string accname;
        string accifsccode;
        int phone;
        
        public Bank()
        {
            accnum = 4203;
            accname = "Siva";
            accifsccode = "sbin077";
            phone = 897654;
        }
        public Bank(int accnum, string accname, string accifsccode, int phone)
        {
            this.accnum = accnum;
            this.accname = accname;
            this.accifsccode = accifsccode;
            this.phone = phone;
        }
        public void GetData()
        {
            Console.WriteLine($"Accout Number:{accnum }\n Account Name:{accname }\nAccount IFSC Code:{accifsccode}\nAccount Phone:{ phone}");
        }
    }
}
