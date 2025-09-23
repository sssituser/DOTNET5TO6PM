using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SwitcEx
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            int b = int.Parse(Console.ReadLine());
        Arun:
            Console.Write("1.ADD\n2.SUB\n3.MUL\n4.DIV\nEnter your choice : ");
           // int choice = int.Parse(Console.ReadLine());
           string choice = Console.ReadLine();
            switch (choice)
            {
                case "+":
                    Console.WriteLine($"{a}+{b}={a+b}");
                    goto Arun;
                case "-":
                    Console.WriteLine($"{a}-{b}={a-b}");
                    goto Arun;
                case "*":
                    Console.WriteLine($"{a}*{b}={a*b}");
                    goto Arun;
                case "/":
                    if(b!=0)
                    {
                        Console.WriteLine($"{a}/{b}={a/b}");
                    }
                    else
                    {
                        Console.WriteLine("Denominator cannot be zero");
                    }
                    
                    goto Arun;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
