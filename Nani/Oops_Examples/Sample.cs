using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Product
    {
        int productId;
        string productName;
        int productPrice;
        int productBatchNo;
        public void GetProductDetails(int productId,string productName,int productPrice,int productBatchNo)
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productBatchNo = productBatchNo;
        }
        public void DisplayProducts()
        {
            Console.WriteLine($"Product ID : {productId}\nProduct Name : {productName}\nProduct Price : {productPrice}\nProduct Batch No :{productBatchNo}");
            Console.WriteLine("*******************************************************************************************");  
        }
    }
    class Employee
    {
        int employeeId;
        string name;
        int salary;
        string jobLocation;
        public void GetEmployeeDetails(int employeeId, string name, int salary, string jobLocation)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.salary = salary;
            this.jobLocation = jobLocation;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID : {employeeId}\nEmployee Name : {name}\nEmployee salary : {salary}\nJob Location : {jobLocation}");
            Console.WriteLine("*******************************************************************************************");

        }
    }
    class Student
    {
        public static int studentId=45;
        public static string studentName="Shana";
        public static string email="shana@gmail.com";
        public static string branch="Cricket";
       /* public static void GetStudentDetails()
        {
            studentId = studentId;
            studentName = studentName;
            email = email;
            branch = branch; 
        } */
        public static void DisplayStudentDetails()
        {
            Console.WriteLine($"Student Id : {studentId}");
            Console.WriteLine($"Student Name : {studentName}");
            Console.WriteLine($"Student e-Mail : {email}");
            Console.WriteLine($"Student branch : {branch}");
            Console.WriteLine("*******************************************************************************************");

        }

    }

    internal class Sample
    {
        static void Main(string[] args)
        {

            Product product = new Product();
            product.GetProductDetails(45, "CEAT Bat", 264, 3);
            product.DisplayProducts();

            Employee employee = new Employee();
            employee.GetEmployeeDetails(45, "Rohit Sharma", 19000, "India");
            employee.DisplayEmployeeDetails();

            
            Student.DisplayStudentDetails();
            

        }
    }
}
