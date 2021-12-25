using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    public class CountOccurencesOfAnagrams
    {
        public void CountTheOccurencesOfAnagrams_BruteForce()
        {
            string input = "forxxorfxdofr";
            string pattern = "for";
            // Explanation: for, orf and ofr appears in input, hence answer is 3.

            //string input = "aabaabaa";
            //string pattern = "aaba";
            //// Explanation: aaba is present 4 times in input

            int countAnagrams = 0;
            int start = 0;
            while (start <= input.Length - pattern.Length)
            {
                int end = start;
                int i = 0;

                char[] cArr = new char[pattern.Length];
                while (end <= start + pattern.Length - 1)
                {
                    cArr[i] = input[end];
                    end++;
                    i++;
                }
                if (IsAnagrams(new string(cArr), pattern))
                {
                    countAnagrams++;
                }
                start++;
            }
            Console.WriteLine($"Total number of anagrams are {countAnagrams}");
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// </summary>
        public bool IsAnagrams(string str1,string str2)
        {
            int n1 = str1.Length;
            int n2 = str2.Length;

            if (n1 != n2)
            {
                return false;
            }

            int[] arr = new int[256];
            //here these arrays will be intialized with all 0s and 
            // index of these arrays are ASCII codes of characters.

            int i = 0;
            while (i < str1.Length)
            {
                arr[str1[i]]++;
                arr[str2[i]]--;

                //arr[str1[i]-'a']++; 
                // It will make values from 0 to 255. e.g: character 'a' value it will set to 0 instead of 97
                //arr[str2[i]-'a']--;

                i++;
            }

            int j = 0;
            while (j < 256)
            {
                if (arr[j] != 0)
                {
                    return false;
                }
                j++;
            }
            return true;
        }

        /// <summary>
        /// Time Complexity: O(n), Auxiliary Space: O(k) 
        /// Idea: Keep character wise count in Map and in each window, if char match, decrement char value
        /// and when char value is zero, decrement varialble 'count' value which needs to be set to
        /// char count initially. When count value is zero in each window, means that window is anagram
        /// </summary>
        public void CountTheOccurencesOfAnagrams_WithSlidingWindow()
        {
            string input = "forxxorfxdofr";
            string pattern = "for";
            // Explanation: for, orf and ofr appears in input, hence answer is 3.

            //string input = "aabaabaa";
            //string pattern = "aaba";
            //// Explanation: aaba is present 4 times in input

            //string input = "bbcc";
            //string pattern = "ca";

            int start = 0;
            int end = 0;
            int k = pattern.Length;
            
            // read all the characters with count in pattern string into dictionary
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (charCounts.ContainsKey(pattern[i]))
                    charCounts[pattern[i]]++;
                else
                    charCounts.Add(pattern[i], 1);
            }
            int count = charCounts.Count;

            int countAnagrams = 0;
            while (end < input.Length)
            {
                int windowSize = end - start + 1;

                // calculations till we hit windowSize
                if (charCounts.ContainsKey(input[end]))
                {
                    charCounts[input[end]]--;

                    if (charCounts[input[end]] == 0)
                        count--;
                }

                if (windowSize < k)
                {
                    end++;
                }
                else if (windowSize == k) //hit windowSize
                {
                    if (count == 0)
                        countAnagrams++;

                    // handle start while sliding the window
                    if (charCounts.ContainsKey(input[start]))
                        charCounts[input[start]]++;

                    if (charCounts.ContainsKey(input[start]))
                    {
                        if (charCounts[input[start]] == 1)
                            count++;
                    }

                    start++;
                    end++;
                }
            }
            Console.WriteLine($"Total number of anagrams are {countAnagrams}");
        }
    }
}
