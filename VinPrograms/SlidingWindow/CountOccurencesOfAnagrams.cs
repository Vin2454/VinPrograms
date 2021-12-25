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
                if (IsAnagramsWithDictionary(new string(cArr), pattern))
                {
                    countAnagrams++;
                }
                start++;
            }
            Console.WriteLine($"Total number of anagrams are {countAnagrams}");
        }

        private bool IsAnagrams(string str1, string str2)
        {
            return false;
        }

        private bool IsAnagramsWithDictionary(string str1, string str2)
        {
            bool isAnagram = false;

            Dictionary<char, int> dic = new Dictionary<char, int>();
            int i = 0;
            while (i<str1.Length)
            {
                if (dic.ContainsKey(str1[i]))
                    dic[str1[i]]++;
                else
                    dic.Add(str1[i], 1);

                i++;
            }

            int j = 0;
            while (j < str2.Length)
            {
                if (dic.ContainsKey(str2[j]))
                {
                    dic[str2[j]]--;
                    if (dic[str2[j]] == 0)
                        dic.Remove(str2[j]);
                }
                else
                {
                    return false;
                }
                j++;
            }

            if (dic.Count == 0)
                return true;

            return isAnagram;
        }

        /// <summary>
        /// Time Complexity: O(n), Auxiliary Space: O(26) or O(256)
        /// </summary>
        public void CountTheOccurencesOfAnagrams_WithSlidingWindow()
        {
            string input = "forxxorfxdofr";
            string pattern = "for";
            // Explanation: for, orf and ofr appears in input, hence answer is 3.

            //string input = "aabaabaa";
            //string pattern = "aaba";
            //// Explanation: aaba is present 4 times in input


        }
    }
}
