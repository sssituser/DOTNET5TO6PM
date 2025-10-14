using System;

namespace MethodsPrograms
{
    internal class AmicablePairsSum
    {
        // Function to calculate the sum of proper divisors
        public static int SumOfDivisors(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int totalSum = 0;

            Console.WriteLine("Amicable pairs between 1 and 1000 are:");
            for (int a = 1; a <= 1000; a++)
            {
                int b = SumOfDivisors(a);
                if (b > a && b <= 1000) // Avoid duplicates
                {
                    if (SumOfDivisors(b) == a)
                    {
                        Console.WriteLine($"({a}, {b})");
                        totalSum += a + b; // add both numbers in the pair
                    }
                }
            }

            Console.WriteLine($"\nSum of all amicable numbers between 1 and 1000: {totalSum}");
        }
    }
}
