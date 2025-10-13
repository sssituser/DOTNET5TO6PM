using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{

    class Manager
    {
        int mid;
        string maname;
        string designation; //instance members
        public void SetManager(int mid,string maname,string designation)
        {
            this.mid = mid;
            this.maname = maname;
            this.designation = designation;
        }
        public void ShowManager()
        {
            Console.WriteLine($"ID : {mid}\nName : {maname}\t{designation}");
        }
    }

    internal class Class5
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.SetManager(123, "venkat", "Project Manager");
            manager.ShowManager();
        }
    }
}
