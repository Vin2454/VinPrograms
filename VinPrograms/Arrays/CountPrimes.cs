using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class CountPrimes
    {
        /// <summary>
        /// Time Complexity: O(n*n)
        /// </summary>
        public void CountPrimeNumbersBruteForce()
        {
            int n = 40;

            int count = 0;
            int i = 2;
            while (i <= n)
            {
                if (IsPrime(i))
                    count++;
                i++;
            }

            Console.WriteLine($"Number of prime numbers: {count}");
        }

        
        private bool IsPrime(int number)
        {
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                    return false;
                i++;
            }
            return true;
        }


        /// <summary>
        /// Time Complexity: O(n*log(log n)), Space Complexity: O(n)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public void CountPrimeNumbersUsing_Sieve_of_Eratosthenes_Method()
        {
            int n = 40;

            int count = 0;
            bool[] isPrime = new bool[n];
            isPrime[0] = isPrime[1] = false;

            // Set all the numbers as Prime (from 2 to n)
            int i = 2;
            while (i < n)
            {
                isPrime[i] = true;
                i++;
            }

            int j = 2;
            while (j < n)
            {
                if (IsPrime(j))
                {
                    count++;

                    // set (2) multiples of a identified prime numbers to false (as non-prime number)
                    int k = 2 * j;
                    while (k < n)
                    {
                        isPrime[k] = false;
                        k = k + j;
                    }
                }
                j++;
            }

            Console.WriteLine($"Number of prime numbers: {count}");
        }
    }
}
