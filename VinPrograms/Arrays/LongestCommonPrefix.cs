using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public class LongestCommonPrefix
    {
        public void FindLongestCommonPrefixMyApproach1()
        {
            //string[] input = { "flower", "flow", "flight" };
            //// expected: fl
            
            string[] input = { "ab", "a"};
            // expected: a 
            // It will throw exception as input[j][i] for input[1][1] throws index out of range exception
            // SO IT IS REQUIRED TO FIND MINIMUM LENGTH STRING AND SEARCH IN OTHER STRINGS
            // e.g: Here need to find string "a" first and then do the search

            if (input==null || input.Length == 0)
            {
                Console.WriteLine(string.Empty); 
            }

            //string s = input[0];// Here we need to find minimum length string. Otherwise program will throw exception for above mentioned scenarios
            string s = GetMinimumLengthString(input);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (s[i] != input[j][i])
                    {
                        Console.WriteLine(sb.ToString());
                        return;
                    }
                }
                sb.Append(s[i]);
            }
            Console.WriteLine(sb.ToString());
        }

        public void FindLongestCommonPrefixMyApproach2()
        {
            //string[] input = { "flower", "flow", "flight" };
            //// expected: fl

            string[] input = { "ab", "a" };
            // expected: a 

            if (input == null || input.Length == 0)
            {
                Console.WriteLine(string.Empty);
            }

            string s = input[0];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j < input.Length; j++) //we can start from second word
                {
                    if (i >= input[j].Length || s[i] != input[j][i]) //i >= input[j].Length check is very important. This means we have already reached maxLength of 2nd and onwards words.
                    {
                        Console.WriteLine(sb.ToString());
                        return;
                    }
                }
                sb.Append(s[i]);
            }
            Console.WriteLine(sb.ToString());
        }

        private string GetMinimumLengthString(string[] input)
        {
            string minLengthWord = input[0];
            int minLength = input[0].Length;

            foreach (var word in input)
            {
                minLength = Math.Min(minLength, word.Length);
                if (minLength == word.Length)
                    minLengthWord = word;
            }
            return minLengthWord;
        }
    }
}
