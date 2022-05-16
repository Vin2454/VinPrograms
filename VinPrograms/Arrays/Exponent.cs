using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class Exponent
    {
        /// <summary>
        /// Stack height = n
        /// </summary>
        public void PrintExponentUsingRecursion()
        {
            // e.g: 2^5...which means multiply 2 with 2 four times
            int m = 2;
            int n = 5;

            Console.WriteLine(ExponentRec(m, n));
        }

        private int ExponentRec(int m, int n)
        {
            //if (n == 0)
            //    return 1;

            //return m * ExponentRec(m, n - 1); //e.g: 2^n = 2 * 2^(n-1)

            // OR
            if (n == 1)
                return m;
            return m* ExponentRec(m, n - 1);
        }

        /// <summary>
        /// Stack height = logn.
        /// Reduces complexity (tree levels here)
        /// </summary>
        public void PrintExponentUsingFastExponentiationRecursion()
        {
            // e.g: 2^5...which means multiply 2 with 2 four times
            int m = 2;
            int n = 5;

            Console.WriteLine(FastExponentRec(m, n));
        }

        private int FastExponentRec(int m, int n)
        {
            if (n == 0)
                return 1;

            int smallAnswer = FastExponentRec(m, n / 2);

            //bool r1 = n % 2 == 0;
            //if(r1)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");

            int r = n & 1;
            // odd
            if (r == 1)
            {
                return m * smallAnswer * smallAnswer;
            }
            else //even
            {
                return smallAnswer * smallAnswer;
            }
        }
    }
}
