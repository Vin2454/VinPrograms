using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// Variable window size sliding window. In this method, we keep number of occurences in Dictionary
        /// Time Complexity: O(n)
        /// Video explanation: https://www.youtube.com/watch?v=L6cffskouPQ&list=PL_z_8CaSLPWeM8BDJmIYDaoQ5zuwyxnfj&index=11
        /// </summary>
        public void LongestSubstringWithoutRepeatingCharacters_WithSlidingWindow()
        {
            //string input = "pwwkew";
            //// expected output: 3 (wke)

            string input = "abcaeba";
            // expected output: 4

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

                if (numberOfUniqueChars < end - start + 1)
                {
                    while (numberOfUniqueChars < end - start + 1)
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
                else if (numberOfUniqueChars == end - start + 1)
                {
                    // get the answer <- calculation
                    LongestSubstring = Math.Max(LongestSubstring, end - start + 1);
                    end++;
                }
            }
            Console.WriteLine($"Longest Substring Length is {LongestSubstring}");
        }

        /// <summary>
        /// Variable window size sliding window. In this method, we keep last occurence of each character in Dictionary
        /// Time Complexity: O(n)
        /// Video explanation: https://www.youtube.com/watch?v=L6cffskouPQ&list=PL_z_8CaSLPWeM8BDJmIYDaoQ5zuwyxnfj&index=11
        /// </summary>
        public void LongestSubstringWithoutRepeatingCharacters_PrateekNarangWay()
        {
            string input = "pwwkew";
            // expected output: 3 (wke)

            //string input = "abcaeba";
            //// expected output: 4

            int start = 0;
            int end = 0;
            int windowSize = 0;
            int LongestSubstring = 0;
            int startWindow = -1;
            Dictionary<char, int> uniqueElementsCounts = new Dictionary<char, int>();

            while (end < input.Length)
            {
                char ch = input[end];

                // below condition must be first here
                // if it exists in dictionary and it's present after(>=) the start of the window
                if (uniqueElementsCounts.ContainsKey(ch) && uniqueElementsCounts[ch] >= start)
                {
                    start = uniqueElementsCounts[ch] + 1;
                    windowSize = end - start; // updated remaining window length excluding current character (end-1)-(start)+1 (similar to j-i+1)
                }

                // update the last occurence
                uniqueElementsCounts[ch] = end;
                windowSize++;
                end++;

                // update LongestSubstring at every step
                if (windowSize > LongestSubstring)
                {
                    LongestSubstring = windowSize;
                    startWindow = start;
                }
            }
            Console.WriteLine($"Longest Substring is {input.Substring(startWindow, LongestSubstring)} with size {LongestSubstring}");
        }
    }
}
