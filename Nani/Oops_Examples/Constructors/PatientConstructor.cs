using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class PatientConstructor
    {
        int patientId;
        string name;
        int medicalBill;
        public PatientConstructor()
        {
            Console.WriteLine("Hii,This is defualt");
            patientId = 1;
            name = "Nani";
            medicalBill = 25000;
            Console.WriteLine("Bye");

        }
        public PatientConstructor(int patientId, string name, int medicalBill)
        {
            Console.WriteLine("Hii,This is parameterised Constructor");
            this.patientId = patientId;
            this.name = name;
            this.medicalBill = medicalBill;
            Console.WriteLine("Bye");
        }
        public void GetPatientDetails()
        {
            Console.WriteLine($"Employee Id : {patientId}\nEmployee name : {name}\nEmployee salary : {medicalBill}");
        }
    }
}
