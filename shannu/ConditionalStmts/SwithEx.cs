using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStmts
{
    internal class SwithEx
    {
        static void Main(string[] args)
        {
            int Balance = 0;
        options:
            Console.Write("1.Deposit\n2.Withdrawal\n3.Check balance\n4.Exit\n");
            Console.Write("Enter Your Choice : ");
            int choice = int.Parse(Console.ReadLine());
           
            switch(choice) {
                case 1:
                    {
                        Console.Write("Enter Deposit Amount : ");
                        
                        int amount = int.Parse(Console.ReadLine());
                        if (amount > 0)
                        {
                            Balance = Balance + amount;
                            Console.WriteLine($"Deposit of {amount} Succesful...");
                        }
                        else
                        {
                            Console.WriteLine("Amount should not be ZERO");
                        }
                        Console.WriteLine();
                    }goto options;
                    case 2:
                    {
                        Console.Write("Enter Withdrawal Amount : ");
                        int amount = int.Parse(Console.ReadLine());

                        if (Balance >= amount)
                        {
                            Balance = Balance - amount;
                            Console.WriteLine($"Withdrawal of {amount} Succesful...");
                        }
                        else
                            Console.WriteLine("You dont have enogh Balance in you Account");
                    }
                    Console.WriteLine();
                    goto options;
                case 3:
                    {
                        
                        Console.WriteLine($"Your current Balance is {Balance}");
                    }
                    Console.WriteLine();
                    goto options;
                case 4:
                    {
                        Console.WriteLine("Thank you For Banking with us!!!");
                        break;
                    }
                    
                        


                    }
        }
    }
}
