namespace projecteuler_cs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics;    /**
    Even Fibonacci numbers
    By considering the terms in the Fibonacci sequence whose values do not exceed N, find the sum of the even-valued terms.
    */
    class Problem2
    {
        static List<long> fib = new List<long>();
        static List<long> even_fibs = new List<long>();

        static long naive_fib(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            return naive_fib(n - 2) + naive_fib(n - 1);
        }

        static long smart_fib(int n)
        {
            fib = new List<long>();
            even_fibs = new List<long>();

            fib.Add(1);
            fib.Add(2);
            even_fibs.Add(2);
            for (int i = 2; i < n; i++)
            {
                var current = fib[i - 2] + fib[i - 1];
                fib.Add(current);
                if (current % 2 == 0) { even_fibs.Add(current); }
            }

            return fib[n - 1];
        }

        static void calc_fib_up_to(long n)
        {
            fib = new List<long>();
            even_fibs = new List<long>();

            if (n <= 1) return;
            fib.Add(1);
            fib.Add(2);
            even_fibs.Add(2);
            if (n == 2) return;

            var i = 2;
            long current = 0;
            do
            {
                current = fib[i - 2] + fib[i - 1];
                if (current > n) { return; }
                fib.Add(current);
                if (current % 2 == 0) { even_fibs.Add(current); }
                //Console.WriteLine("current = {0}", current);
                ++i;
            } while (true);
        }

        public static long solution(long n)
        {
            calc_fib_up_to(n);
            return even_fibs.Sum();
        }

        public static void Run()
        {
            int t = int.Parse(Console.ReadLine());
            for (int ii = 0; ii < t; ++ii)
            {
                long n = long.Parse(Console.ReadLine());

                Console.WriteLine(solution(n));
            }
        }
    }
}
