using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    /// <summary>
    /// Question: https://leetcode.com/problems/minimum-window-substring/
    /// </summary>
    public class MinimumWindowSubString
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=iwv1llyN6mo&list=PL_z_8CaSLPWeM8BDJmIYDaoQ5zuwyxnfj&index=13
        /// </summary>
        public void MinimumWindowSubString_SlidingWindow_AdityaVermaWay()
        {
            //string input = "timetopractice";
            //string pattern = "toc";
            ////// Expected toprac

            //string input = "HELLO";
            //string pattern = "EO";
            //// Expected ELLO

            string input = "ADOBECODEBANC";
            string pattern = "ABC";
            ////Expected output: BANC
            ////Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string pattern

            Dictionary<char, int> neededCharacters = new Dictionary<char, int>();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!neededCharacters.ContainsKey(pattern[i]))
                    neededCharacters.Add(pattern[i], 1);
                else
                    neededCharacters[pattern[i]]++;
            }
            int neededCharactersCount = neededCharacters.Count;

            int start = 0;
            int end = 0;

            int minStart = 0;
            int minEnd = 0;
            int minLen = int.MaxValue;

            while (end < input.Length)
            {
                if (neededCharacters.ContainsKey(input[end]))
                {
                    neededCharacters[input[end]]--;
                    if (neededCharacters[input[end]] == 0)
                    {
                        neededCharactersCount--;
                    }
                }

                // as soon as all the required characters found , then "start" pointer needs to be moved to right. 
                // we can have multiple answers and hence while loop for the answer condition
                while (neededCharactersCount <= 0)
                {
                    if (end - start + 1 < minLen)
                    {
                        minLen = end - start + 1;
                        minStart = start;
                        minEnd = end + 1;
                    }

                    if (neededCharacters.ContainsKey(input[start]))
                    {
                        neededCharacters[input[start]]++;

                        if (neededCharacters[input[start]] > 0)
                        {
                            neededCharactersCount++;
                        }
                    }
                    start++;
                }
                end++;
            }
            Console.WriteLine($"{input.Substring(minStart, minEnd - minStart)}");
        }

        public void MinimumWindowSubString_SlidingWindow_ExpandContract_PrateekNarangWay()
        {
            string input = "timetopractice";
            string pattern = "toc";

            //string input = "HELLO";
            //string pattern = "EO";
            //// Expected ELLO

            //string input = "ADOBECODEBANC";
            //string pattern = "ABC";
            ////Expected output: BANC
            ////Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string pattern

            // here we are using array has patternFrequency map. We can also use Dictionary
            int[] patternFrequency = new int[256];
            int[] inputFrequencyWindow = new int[256];

            for (int i = 0; i < pattern.Length; i++)
            {
                patternFrequency[pattern[i]]++;
            }

            // sliding window algorithm
            int count = 0;
            int start = 0; // for the left contraction
            int startIndex = -1; // start index for best window
            int minSoFar = int.MaxValue; // large number
            int windowSize;

            for (int i = 0; i < input.Length; i++)
            {
                // expand the window towards right by including current character
                char currentChar = input[i];
                inputFrequencyWindow[currentChar]++;

                // count how many characters have been matched till now between pattern & input
                if (patternFrequency[currentChar] != 0 && inputFrequencyWindow[currentChar] <= patternFrequency[currentChar])
                {
                    count++;
                }

                // if all the characters of the pattern are found in the current window, then you can start contracting
                if (count == pattern.Length)
                {
                    // start contracting from the left to remove unwanted characters (not present in pattern or it's current frequency is higher than required)
                    while (patternFrequency[input[start]] == 0 || inputFrequencyWindow[input[start]] > patternFrequency[input[start]])
                    {
                        inputFrequencyWindow[input[start]]--;
                        start++;
                    }

                    // note the window size
                    windowSize = i - start + 1;
                    if (windowSize < minSoFar)
                    {
                        minSoFar = windowSize;
                        startIndex = start;
                    }
                }
            }
            if (startIndex == -1)
                Console.WriteLine($"No window found");
            else
                Console.WriteLine($"{input.Substring(startIndex, minSoFar)}");
        }
    }
}
