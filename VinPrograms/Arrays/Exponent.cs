using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class Exponent
    {
        public void PrintExponentUsingRecursion()
        {
            // e.g: 2^5...which means multiply 2 with 2 four times
            int m = 2;
            int n = 5;

            Console.WriteLine(ExponentRec(m, n));
        }

        private int ExponentRec(int m, int n)
        {
            if (n == 0)
                return 1;

            return m * ExponentRec(m, n - 1); //e.g: 2^n = 2 * 2^(n-1)
        }

        /// <summary>
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

            // odd
            int r = n & 1;
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
