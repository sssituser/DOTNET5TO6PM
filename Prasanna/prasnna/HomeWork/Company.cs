using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Company
    {
        string CompanyName;
        String CompanyLocation;
        

        public Company()
        {
            CompanyName = "TCS";
            CompanyLocation = "Hyderabad";
        }

        public Company( string CompanyName,String CompanyLocation)
        {
            this.CompanyName = CompanyName;
            this.CompanyLocation = CompanyLocation;
        }

        public void GetData()
        {
            Console.WriteLine($"COmpany Name:{CompanyName}\n Company Location:{CompanyLocation }");
        }
        
    }
}
