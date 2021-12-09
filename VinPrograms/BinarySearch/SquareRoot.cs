using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.BinarySearch
{
    public class SquareRoot
    {
        /// <summary>
        /// if n is 100000, this program will not give correct result. Need to handle it.
        /// </summary>
        public int FindSquareRootWithoutPrecision(int n)
        {
            n = 37;
            //int n = 36;
            // int n=100000; //it gives incorrect result

            int start = 0;
            int end = n;
            int mid = -1;
            int ans = -1;

            while (start<=end)
            {
                mid = start + (end - start) / 2;
                int square = mid * mid;
                if (square == n)
                {
                    //Console.WriteLine($"Square root of {n} is {mid}");
                    //return;

                    return mid;
                }
                else if (square < n)
                {
                    ans = mid;
                    start = mid + 1;
                }
                else if (square > n)
                {
                    end = mid - 1;
                }
            }
            //Console.WriteLine($"Square root of {n} is {ans}");

            return ans;
        }

        public void FindSquareRootWithPrecision()
        {
            int n = 37;
            //int n = 36;
            // int n=100000; //it gives incorrect result

            int squareRootIntegerValue = FindSquareRootWithoutPrecision(n);
            double ans = GetMorePrecision(n, 3, squareRootIntegerValue);
            Console.WriteLine($"Square root of a number {n} is {ans} with precision");
        }
        public double GetMorePrecision(int n,int precision,int squareRootIntegerValue)
        {
            double factor = 1;
            double ans = squareRootIntegerValue;
            for (int i = 0; i < precision; i++)
            {
                factor = factor / 10;
                for (double j = ans; j*j < n; j=j+factor)
                {
                    ans = j;
                }
            }
            return ans;
        }
    }
}
