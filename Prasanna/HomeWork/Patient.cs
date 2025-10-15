using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Patient
    {
        int Patientid;
        string Patientname;
        string Patientdescription;
        int PatientAge;

        public Patient()
        {
            Patientid = 100;
            Patientname = "Raju";
            Patientdescription = "Fever";
            PatientAge = 23;
        }

        public Patient(int patientid, string patientname, string patientdescription, int patientAge)
        {
            Patientid = patientid;
            Patientname = patientname;
            Patientdescription = patientdescription;
            PatientAge = patientAge;
        }

        public void GetData()
        {
            Console.WriteLine($"Patient Id:{Patientid}\nPatient Name:{Patientname }\nPatient Description:{Patientdescription}\nPatient Age:{PatientAge }");
        }
    }
}
