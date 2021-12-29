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
        public void MinimumWindowSubString_SlidingWindow_ExpandContract()
        {
            //string input = "HELLO";
            //string pattern = "EO";
            //// Expected ELLO

            string input = "ADOBECODEBANC";
            string pattern = "ABC";
            //Expected output: BANC
            //Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string pattern

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
