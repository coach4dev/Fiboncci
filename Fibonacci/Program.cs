using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            Console.WriteLine("Fibonacci Number at index " + n + " Using Recursion Result: " + GetNthFibonacciUsingRecursion(n));
            Console.WriteLine("Fibonacci Number at index " + n + " Using Memoization Result: " + GetNthFibonacciUsingdMemoization(n));
            Console.WriteLine("Fibonacci Number at index " + n + " Using Space Optimization Result: " + GetNthFibonacciUsingSpaceOptimized(n));
            Console.ReadLine();
        }

        private static int GetNthFibonacciUsingRecursion(int n)
        {
            if (n <= 1)
                return n;
            return GetNthFibonacciUsingRecursion(n - 1) + GetNthFibonacciUsingRecursion(n - 2);
        }

        private static int GetNthFibonacciUsingdMemoization(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 0);
            dict.Add(1, 1);
            for (int x = 2; x < n + 1; x++)
            {
                dict.Add(x, dict[x - 1] + dict[x - 2]);
            }
            return dict[n];
        }

        private static int GetNthFibonacciUsingSpaceOptimized(int n)
        {
            if (n <= 1)
                return n;
            int prevprev = 0;
            int prev = 1;
            int current = prevprev + prev;
            for (int x = 2; x < n; x++)
            {
                prevprev = prev;
                prev = current;
                current = prevprev + prev;

            }
            return current;
        }
    }
}
