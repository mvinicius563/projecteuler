namespace projecteuler_cs
{
    using System;

    /**
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    Find the sum of all the multiples of 3 or 5 below
    */
    class Problem1
    {        public static long solution(long n)
        {
            /*
            long sum = 0;
            for (int i = 3; i < n; i++){
                if (i % 3 == 0) {
                    sum += i;
                } else if (i % 5 == 0) {
                    sum += i;
                }
            }
            return sum;
            */
            n--;
            //arithmetic progression formula: (number of elements) x (first element + last element) / 2
            long sum3 = (n / 3) * (3 + (n - n % 3)) / 2;
            long sum5 = (n / 5) * (5 + (n - n % 5)) / 2;
            long sum15 = (n / 15) * (15 + (n - n % 15)) / 2;
            return sum3 + sum5 - sum15;
        }

        public static void Run()
        {
            int t = int.Parse(Console.ReadLine());
            for (int ii = 0; ii < t; ++ii)
            {
                Console.WriteLine(solution(long.Parse(Console.ReadLine())));
            }
        }
    }
}
