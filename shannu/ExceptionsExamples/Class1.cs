using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExamples
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter  a Age value :  ");
                    int a = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Enter b age value : ");
                    //int b= int.Parse(Console.ReadLine());
                    if (a <= 0 || a > 120)
                    {
                        throw new InvalidAgeException("Age should be in betwwe 1 and 120");
                    }
                    Console.WriteLine($"Entered age is : {a}");
                }
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }

            }
        }
    }

