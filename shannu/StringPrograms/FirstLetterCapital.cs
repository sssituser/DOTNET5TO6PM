using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class FirstLetterCapital
    {
        /*Capitalize First Letter of Each Word

Problem: Convert "hello world from csharp" to "Hello World From Csharp" using Split(), Substring(), and ToUpper().*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a STring : ");
            string Input = Console.ReadLine().ToLower();
            String Output = "";
            if(Input.Contains(" "))
            {
                string[] words = Input.Split(' ');
                foreach (string word in words)
                {
                    string wordFirstLetter = word.Substring(0, 1).ToUpper();
                    string wordRest = word.Substring(1).ToLower();

                    Output += wordFirstLetter + wordRest + " ";
                }
                Console.WriteLine(Output);

                int a = 122;
                int a = 123;
                int a = 124;
                Console.WriteLine(a);
            }
        }
    }
}
