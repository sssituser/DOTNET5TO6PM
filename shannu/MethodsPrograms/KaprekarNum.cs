using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPrograms
{
    internal class KaprekarNum
    {

        
            public static string isKaprekarNumber(int num)
            {
             

                //  Square the number
                int Square = num * num;  
                string str = Square.ToString();

                // 3 Split the square into two parts
                int Len = str.Length;
                int SplitPos = Len / 2;

                string Left = str.Substring(0, SplitPos);
                string Right = str.Substring(SplitPos);

                //  Convert parts to integers 
                int LeftNum =  int.Parse(Left);
                int RightNum = int.Parse(Right);

                //  Check if sum equals the original number
                if (LeftNum + RightNum == num)
                    return "True";
                else
                    return "False";


            }
        public static string KaprekarTestCases(int num)
        {
            // Test cases
            if (num < 0)
                return "-1";
            if (num == 0)
                return "-2";
        }
            static void Main(string[] args)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                
                Console.WriteLine($"Output: {isKaprekarNumber(num)}");
                Console.WriteLine(KaprekarTestCases(num));
            }
        }
    }


