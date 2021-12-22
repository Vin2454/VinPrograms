using System;
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

            int e1 = 0;
            int e2 = 1;

            int i = 1;
            while (i <= n)
            {
                if (i == 1)
                {
                    Console.Write(e1 + " ");
                }
                else if (i == 2)
                {
                    Console.Write(e2 + " ");
                }
                else
                {
                    int e3 = e1 + e2;
                    Console.Write(e3 + " ");

                    e1 = e2;
                    e2 = e3;
                }

                i++;
            }
        }

        public void FinbanacciWithRecursion()
        {
            int n = 7;

            int i = 1;
            while (i <= n)
            {
                Console.Write(Fibonacci(i) + " ");

                i++;
            }
        }

        private int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return n - 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
