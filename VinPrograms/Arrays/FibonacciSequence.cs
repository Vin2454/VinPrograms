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

            int f0 = 0;
            int f1 = 1;

            int i = 0;
            while (i < n)
            {
                if (i < 2)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    int f2 = f0 + f1;

                    Console.Write(f2 + " ");
                    f0 = f1;
                    f1 = f2;
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
                    Console.Write(Fibonacci(i) + " ");

                    i++;
                }
                Console.WriteLine();
            }
        }

        private int Fibonacci(int n)
        {
            if (n < 3)
                return n-1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
