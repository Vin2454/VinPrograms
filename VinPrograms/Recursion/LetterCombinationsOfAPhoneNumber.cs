using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Recursion
{
    /// <summary>
    /// Question: https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// </summary>
    public class LetterCombinationsOfAPhoneNumber
    {
        public void LetterCombinationsOfPhoneNumber()
        {
            //string digits = "23";
            //Expected output:["ad","ae","af","bd","be","bf","cd","ce","cf"]

            string digits = "23";

            //int a = digits[0] - '0';
            //int b = digits[1] - '0';
            //Console.WriteLine(a + " " + b); // 2 3

            //int a = digits[0]; 
            //int b = digits[1]; 
            //Console.WriteLine(a + " " +b); // 50 51

            char a = digits[0];
            char b = digits[1];
            Console.WriteLine(a + " " + b); // 2 3
        }
    }
}
