using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Program
    {
        int id;
        string patientName;
        int age;
        public void Display(int id, string patientName, int age)
        {
            this.id = id;
            this.patientName = patientName;
            this.age = age;
            Console.WriteLine($"Patient Id is : {id}");
            Console.WriteLine($"Patient name is : {patientName}");
            Console.WriteLine($"Patient age : {age}");
            Console.WriteLine("\n\n");


        }
       
        static void Main(string[] args)
        {
            Program patient = new Program();
            patient.Display(1, "Nani", 22);
            patient.Display(2, "venky", 22);

            Program patient2 = new Program();
            patient2.Display( 45, "Rohit", 264);

        }
    }
}
