using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppADoExample
{
    internal class Program 
    { static void Main(string[] args)
        {
            BusinessLogic bl;
            while (true)
            {
                Console.Write("1.Insert\n2.Delete\n3.Updtae\n4.Find\n5.FindAll\nEnter ur choice :");
                int choice = int.Parse(Console.ReadLine()); 
                Student stu = new Student();
                switch (choice)
                {
                    case 1:
                        try 
                        {
                            Console.Write("Enter Student ID : ");
                            stu.id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Name : ");
                            stu.name = Console.ReadLine();
                            Console.Write("Enter year : ");

                            stu.year = int.Parse(Console.ReadLine());
                            Console.Write("Enter Location : ");
                            stu.loc = Console.ReadLine();
                            Console.Write("Enter Gender : ");
                            stu.gen= Console.ReadLine();


                            bl = new BusinessLogic();
                            if (bl.AddStudent(stu))
                            {
                                Console.WriteLine("Student Added");
                            }
                            else
                            {
                                Console.WriteLine("Student Insertion Failed");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (Exception ex) { 
                            Console.WriteLine($"Error Messagae :{ex.Message}");
                        }
                       
                        break;
                    case 2:
                        Console.Write("Enter Student ID : ");
                        int eid = int.Parse(Console.ReadLine());
                        bl = new BusinessLogic();
                        if (bl.DeleteStudent(eid))
                        { 
                            Console.WriteLine("Student Removed ...");
                        }
                        else
                        {
                            Console.WriteLine("Student Removal Failed...");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Enter Student ID : ");
                        stu.id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student Name : ");
                        stu.name = Console.ReadLine();
                        Console.Write("Enter year : ");
                        stu.year = int.Parse(Console.ReadLine());
                        Console.Write("Enter Location : ");
                        stu.loc = Console.ReadLine();
                        
                        bl = new BusinessLogic();
                        if (bl.UpdateStudent(stu))
                        {
                            Console.WriteLine("Student updated");
                        } 
                        else 
                        {
                            Console.WriteLine("Student updation Failed");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4: 
                        Console.Write("Enter Student ID : ");
                        eid = int.Parse(Console.ReadLine());
                        bl = new BusinessLogic();
                        stu = bl.GetStudent(eid);
                     
                        Console.WriteLine($"Student ID : {stu.id}\nStudent Name : {stu.name}\nStudent Salary : {stu.year}\nStudent Location : {stu.loc}\nStudent Gender : {stu.gen}");
                        
                        Console.ReadKey();
                        Console.Clear();
                        break;
                      
                    case 5:
                      
                        Console.WriteLine("StudentID\t\tEmmployee Name\t\tStudent Salary\t\tStudent Location\t\tStudent Gender ");
                     
                        bl = new BusinessLogic();
                       ArrayList stulist = bl.GetStudentList(); 
                        foreach (Student Student in stulist)
                        {
                            Console.WriteLine($"{Student.id}\t\t\t{Student.name}\t\t\t{Student.year}\t\t\t{Student.loc}\t\t\t\t{Student.gen}");
                        }
                    
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }
               
              
            }
            
        }
    }
}
