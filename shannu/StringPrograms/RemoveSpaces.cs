using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class RemoveSpaces
    {
        /* Remove Spaces

Problem: Remove all spaces from a string.

Input: "Hello World" → Output: "HelloWorld"*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string Input = Console.ReadLine();

            
            
                Input = Input.Replace(" ","");
           
          

            Console.WriteLine(Input);
        }
    }
}
