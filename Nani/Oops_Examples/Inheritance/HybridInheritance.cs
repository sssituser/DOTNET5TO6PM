using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    interface IColleges
    {

        void CollegesInfo();
        

    }
    interface INRI : IColleges
    {
        void NRICollegeInfo();
        
            
        
    }
    interface FreeChaitanya : IColleges
    {
        void FreeChaitanyaCollegeInfo();
        
            
        
    }
    interface ICollegeStudent : INRI , FreeChaitanya
    {
        void StudentInfo();
    }
    class NRIStudent : ICollegeStudent
    {
        public void CollegesInfo()
        {
            Console.WriteLine("List of colleges are \n 1.NRI \n 2.FreeChaitanya");
        }
        public void NRICollegeInfo()
        {
            Console.WriteLine("College Name : NRI \nCollege Code : 1001");
        }
        public void FreeChaitanyaCollegeInfo()
        {

        }
        public void StudentInfo()
        {

            CollegesInfo();
            NRICollegeInfo();
            Console.WriteLine($"Student Name : Nani \n Student Id : 45");
        }
    }


        class FreeChaitanyaStudent : ICollegeStudent
        {
            public void CollegesInfo()
            {
                Console.WriteLine("List of colleges are \n 1.NRI \n 2.FreeChaitanya");
            }
            public void NRICollegeInfo()
            {
                
            }
            public void FreeChaitanyaCollegeInfo()
            {
                Console.WriteLine("College Name : Free Chaitanya \nCollege Code : 1002");
            }

            public void StudentInfo()
            {

                CollegesInfo();
                FreeChaitanyaCollegeInfo();
                Console.WriteLine($"Student Name : Shana \n Student Id : 111");
            }
        }


    internal class HybridInheritance
    {
        static void Main(string[] args)
        {
             NRIStudent nriStudent1 = new NRIStudent();
            nriStudent1.StudentInfo();

            Console.WriteLine("\n\n");
            FreeChaitanyaStudent fcStudent1= new FreeChaitanyaStudent();
            fcStudent1.StudentInfo();
        }
    }




    
    
}
