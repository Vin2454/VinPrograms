using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    /// <summary>
    /// Fibonacci number many ways explained @https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/
    /// </summary>
    public class FibonacciSequence
    {
        /// <summary>
        /// Time Complexity: O(n)
        /// </summary>
        public void FinbanacciWithIteration()
        {
            int n = 7;

            if (n < 1)
                return;

            int f1 = 0;
            int f2 = 1;

            int i = 0;
            while (i < n)
            {
                if (i < 2)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    int f3 = f1 + f2;

                    Console.Write(f3 + " ");
                    f1 = f2;
                    f2 = f3;
                }

                i++;
            }
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// </summary>
        public void FinbanacciWithIterationAlmostSameAsAbove()
        {
            int n = 7;

            if (n < 1)
                return;

            int f0 = 0;
            int f1 = 1;

            int i = 1;
            while (i <= n)
            {
                if (i == 1)
                {
                    Console.Write(f0 + " ");
                }
                else if (i == 2)
                {
                    Console.Write(f1 + " ");
                }
                else
                {
                    int f3 = f0 + f1;
                    Console.Write(f3 + " ");

                    f0 = f1;
                    f1 = f3;
                }

                i++;
            }
        }

        public void FinbanacciWithRecursion()
        {

            while (true)
            {
                Console.Write($"Enter number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int i = 1;
                while (i <= n)
                {
                    int numberOfFunctionCalls = 0;
                    //Console.Write(Fibonacci(i, ref numberOfFunctionCalls) + " ");
                    Console.WriteLine($"fib({i}) is {Fibonacci(i, ref numberOfFunctionCalls)} with numberOfFunctionCalls: {numberOfFunctionCalls}");

                    i++;
                }
                Console.WriteLine();
            }
        }

        private int Fibonacci(int n,ref int numberOfFunctionCalls)
        {
            numberOfFunctionCalls++;

            if (n < 3)
                return n-1;
            return Fibonacci(n - 1,ref numberOfFunctionCalls) + Fibonacci(n - 2,ref numberOfFunctionCalls);
        }

        public void FibonacciWithRecursionAndDPMyWay()
        {
            while (true)
            {
                Console.Write($"Enter number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                while (i <= n)
                {
                    // Since we defined calculatedFibonacciValues inside while loop, for fib(n),there will be n number of function calls. If we define this
                    // above while loop, previous computations will be reused, but there will be more space usage.
                    Dictionary<int, long> calculatedFibonacciValues = new Dictionary<int, long>();

                    int numberOfFunctionCalls = 0;

                    //Console.Write(FibonacciDP(i, calculatedFibonacciValues, ref numberOfFunctionCalls) + " ");
                    Console.WriteLine($"fib({i}) is {FibonacciDPMyWay(i, calculatedFibonacciValues, ref numberOfFunctionCalls)} with numberOfFunctionCalls: {numberOfFunctionCalls}");

                    i++;
                }
                Console.WriteLine();
            }
        }

        private long FibonacciDPMyWay(int n, Dictionary<int, long> calculatedFibonacciValues,ref int numberOfFunctionCalls)
        {
            numberOfFunctionCalls++;

            if (n < 3)
            {
                calculatedFibonacciValues.Add(n, n - 1);
                return n - 1;
            }

            long a;
            if (calculatedFibonacciValues.ContainsKey(n - 1))
            {
                a = calculatedFibonacciValues[n - 1];
            }
            else
            {
                a = FibonacciDPMyWay(n - 1, calculatedFibonacciValues, ref numberOfFunctionCalls);
                if (!calculatedFibonacciValues.ContainsKey(n - 1)) // this check is required. Key-Value might be added, but while backtracking it comes to this else block
                    //and tries to add again. So without this condition, throws exception.
                    calculatedFibonacciValues.Add(n-1, a);
            }

            long b;
            if (calculatedFibonacciValues.ContainsKey(n - 2))
            {
                b = calculatedFibonacciValues[n - 2];
            }
            else
            {
                b = FibonacciDPMyWay(n - 2, calculatedFibonacciValues, ref numberOfFunctionCalls);
                if (!calculatedFibonacciValues.ContainsKey(n - 2)) // this check is required. Key-Value might be added, but while backtracking it comes to this else block
                    //and tries to add again. So without this condition, throws exception.
                    calculatedFibonacciValues.Add(n-2, b);
            }
            return a + b;
        }
    }
}
