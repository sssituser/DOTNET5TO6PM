using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Class8
    {
        public static int GetMaxNum(int[] array)
        {
           return ArrayToNum(SortArrayInDesc(GetMaxDigitsArray(array)));
        }
        public static int[] GetMaxDigitsArray(int[] array) //{123,456}
        {
            int[] res = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                res[i] = GetMaxDigit(array[i]);
            }
            return res;

        }

        public static int GetMaxDigit(int num) // 321
        {
            int max = num % 10; // max = 1
            while (num > 0) // 321>0 32>0 3>0 0>0
            {
                int digit = num % 10; // digit = 1 digit = 2 digit = 3
                if (max < digit) // 1<2 2<3
                {
                    max = digit; // max = 2 max = 3
                }
                num /= 10;// num = 321/10 num = 32/10 num = 3/10 num = 0

            }
            return max;
        }
        public static int[] SortArrayInDesc(int[] array) // {7,5,4}
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        public static int ArrayToNum(int[] array) //{5,4,7}
        {
            int res = 0;
            foreach (int i in array) //{5,4,7}
            {
                res = res * 10 + i; // res = 5 res = 54 res = 547
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] array = { 123, 100, 201, 412, 514, 719 };
            Console.WriteLine(GetMaxNum(array));

        }
    }
}
