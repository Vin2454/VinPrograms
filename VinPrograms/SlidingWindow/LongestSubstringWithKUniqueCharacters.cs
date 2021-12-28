using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    public class LongestSubstringWithKUniqueCharacters
    {
        /// <summary>
        /// Variable window size sliding window
        /// Time Complexity: O(n)
        /// Video explanation: https://www.youtube.com/watch?v=Lav6St0W_pQ&list=PL_z_8CaSLPWeM8BDJmIYDaoQ5zuwyxnfj&index=10
        /// </summary>
        public void LongestSubstringWithKUniqueCharacters_WithSlidingWindow()
        {
            string input = "aabacbebebe";
            int k = 3;
            // expected output: 7

            //string input = "aaaa";
            //int k = 1;
            //// expected output: 4

            int start = 0;
            int end = 0;
            Dictionary<char, int> uniqueElementsCounts = new Dictionary<char, int>();

            int numberOfUniqueChars = 0;
            int LongestSubstring = 0;
            while (end < input.Length)
            {
                // Calculations
                if (!uniqueElementsCounts.ContainsKey(input[end]))
                    uniqueElementsCounts.Add(input[end], 1);
                else
                    uniqueElementsCounts[input[end]]++;

                numberOfUniqueChars = uniqueElementsCounts.Count;

                if (numberOfUniqueChars < k)
                    end++;
                else if (numberOfUniqueChars == k)
                {
                    // get the answer <- calculation
                    LongestSubstring = Math.Max(LongestSubstring, end - start + 1);
                    end++;
                }
                else if (numberOfUniqueChars > k)
                {
                    while (numberOfUniqueChars > k)
                    {
                        // Remove calculations for start
                        uniqueElementsCounts[input[start]]--;
                        if (uniqueElementsCounts[input[start]] == 0)
                        {
                            uniqueElementsCounts.Remove(input[start]);
                            numberOfUniqueChars--;
                        }
                        start++;
                    }
                    end++;
                }
            }
            Console.WriteLine($"Longest Substring Length is {LongestSubstring}");
        }
    }
}
