using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class11
    {
            public static int GetMaxNum(int[] array)
            {
                return ArrayToNum(SortArrayInDesc(GetMaxDigitsArray(array)));
            }
            public static int[] GetMaxDigitsArray(int[] array) 
            {
                int[] res = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    res[i] = GetMaxDigit(array[i]);
                }
                return res;

            }

            public static int GetMaxDigit(int num) 
            {
                int max = num % 10; 
                while (num > 0)
                {
                    int digit = num % 10;
                    if (max < digit) 
                    {
                        max = digit; 
                    }
                    num /= 10;

                }
                return max;
            }
            public static int[] SortArrayInDesc(int[] array) 
            {
                Array.Sort(array);
                Array.Reverse(array);
                return array;
            }

            public static int ArrayToNum(int[] array) 
            {
                int res = 0;
                foreach (int i in array) 
                {
                    res = res * 10 + i; 
                }
                return res;
            }
            static void Main(string[] args)
            {
                int[] array = { 153, 244, 789, 678, 786, 987 };
                Console.WriteLine(GetMaxNum(array));

            }
    }
}

