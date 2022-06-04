using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class Maximum69Number
    {
        public void Max69Number()
        {
            int num = 9969;
            int reversedNumber = ReverseNumber(num);

            int max69 = 0;
            bool first6 = false;
            while (reversedNumber > 0)
            {
                int remainder = reversedNumber % 10;
                if (remainder == 6 && !first6)
                {
                    first6 = true;
                    remainder = 9;
                }

                max69 = max69 * 10 + remainder;
                reversedNumber = reversedNumber / 10;
            }

            Console.WriteLine(max69); 
        }

        public int ReverseNumber(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                sum = sum * 10 + remainder;
                n = n / 10;
            }
            return sum;
        }
    }
}
