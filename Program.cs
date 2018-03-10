using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Program
    {
        static long Fib(int n)
        {
            if (n == 1 || n == 2)
                return 1L;

            return Fib(n - 1) + Fib(n - 2);

        }

        static long MFib(int n, Dictionary<int, long> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            if (n == 1 || n == 2)
            {
                memo.Add(n, 1);
                return 1L;
            }

            long result = MFib(n - 1, memo) + MFib(n - 2, memo);
            memo.Add(n, result);
            return result;
        }

        static long BFib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1L;
            }

            long p1 = 1;
            long p2 = 1;

            for (int i = 1; i < n; i++)
            {
                long current = p1 + p2;
                p2 = p1;
                p1 = current;
            }

            return p1;
        }

        static void Main(string[] args)
        {
            Dictionary<int, long> memo = new Dictionary<int, long>();

            Console.WriteLine(BFib(40));
            Console.ReadLine();
        }
    }
}
