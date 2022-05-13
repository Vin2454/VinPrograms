using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    class SumOfDigits
    {
        public void PrintSumOfDigits()
        {
            int n, sum = 0, digit;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                digit = n % 10;
                sum = sum + digit;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);
        }
    }
}
