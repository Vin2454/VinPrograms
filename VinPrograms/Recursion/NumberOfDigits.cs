using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Recursion
{
    public class NumberOfDigits
    {
        public void CountNumberOfDigits()
        {
            Console.WriteLine(CountRec(1234)); //expected output: 4
        }

        int CountRec(int n)
        {
            /// base
            if (n == 0)
            {
                return 0;
            }
            /// recursive
            int smallAns = CountRec(n / 10);

            /// calculation
            return smallAns + 1;
        }
    }
}
