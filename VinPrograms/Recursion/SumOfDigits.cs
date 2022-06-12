using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Recursion
{
    public class SumOfDigits
    {
        public void SumOfDigitsWithRecursion()
        {
            Console.WriteLine(SumOfDigitsRecursion(1234));
        }
        private int SumOfDigitsRecursion(int n)
        {
            /// base case
            if (n == 0)
            {
                return 0;
            }

            /// recursive
            int smallAns = SumOfDigitsRecursion(n / 10);

            /// calculation
            int last_digit = n % 10;
            return smallAns + last_digit;
        }
    }
}
