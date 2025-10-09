using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MultipleLists
    {
        public static string ListOfNumbers(int start, int end)
        {
            return $"\nPalindrome list : {PalindromeList(start, end)}\n\nAmstrong list : {AmstrongNumbersList.AmstrongList(start, end)}\n\nPrime Numbers List : {ListOfPrimeNumbers.PrimeList(start, end)}\n\nList of Adam Numbers : {AdamList(start , end)}\n\nList of perfect numbers : {PerfectList(start,end)}";
        }
        public static string PalindromeList(int start, int end)
        {
            string res = string.Empty;
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (IsPalindrome(i))
                {
                    res += i + ",";
                    count++;
                }
            }
            return $"{res.Substring(0, res.Length - 1)}.\nTotal Palindromes are : {count}";
        }
        public static bool IsPalindrome(int num)
        {
           
            
            if(num != ReverseNumber(num))
            {
                return false ;
            }
            return true ;
        }
            public static int ReverseNumber(int num)
            {
                int reverseNumber = 0;
                
                while (num > 0)
                {
                    int digit = num % 10;
                    reverseNumber = (reverseNumber * 10) + digit;
                    num = num / 10;
                }

                return reverseNumber;
            }
        public static string AdamList(int start , int end)
        {
            string res = string.Empty ;
            int count = 0;
            for(int i = start; i <= end;i++)
            {
                if(SquareOfTheNumber(i)==ReverseNumber(SquareOfTheNumber(i)))
                {
                    res += i + ",";
                    count++;

                }
            }
            return $"{res.Substring(0,res.Length-1)}.\nTotal Adam no. are : {count}" ;

        }
        public static int SquareOfTheNumber(int num)
        {
            return num * num;
        }
        public static string PerfectList(int start,int end)
        {
            string res= string.Empty ;
            int count = 0;
            for(int i=start;i<=end;i++)
            {
                if(i==FactSum(i))
                {
                    res+= i + ",";
                    count++;
                }
            }
            return $"{res.Substring(0, res.Length - 1)}.\nTotal perfect no. {count}";
        }
        public static int FactSum(int num)
        {
            int sum = 0;
            for(int i=1;i<num;i++)
            {
                if(num%i==0)
                {
                    sum += i;
                }
            }
            return sum;
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the start value : ");
            int start=int.Parse(Console.ReadLine());
            Console.Write("Enter the End value : ");
            int end=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(ListOfNumbers(start, end));
             
        }
    }
}
