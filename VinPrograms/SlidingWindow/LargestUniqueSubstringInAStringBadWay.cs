using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    /// <summary>
    /// 1) Generate Substring (here SubArray ?) 2) Identify unique Substring 3) Identify largest unique Substring
    /// </summary>
    public class LargestUniqueSubstringInAStringBadWay
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/print-longest-substring-without-repeating-characters/
        /// Time Complexity: O(n)
        /// </summary>
        public void PrintLargestUniqueSubstringInAString_SlidingWindow()
        {

        }

        public void PrintLargestUniqueSubstringInAString_BruteForce()
        {
            string input = "abcabea";
            //string input = "abcba";

            // expected output: cabe

            LargestUniqueSubstringInAString_Badway(input);
        }

        private void LargestUniqueSubstringInAString_Badway(string input)
        {
            Dictionary<string,int> uniequeSubstrings = new Dictionary<string, int>();
            GenerateSubstringsRec(uniequeSubstrings, input, 0, 0);
            PrintUniqueSubstringsWithCount(uniequeSubstrings);
        }

        private void PrintUniqueSubstringsWithCount(Dictionary<string, int> uniequeSubstrings)
        {
            int maxLength = int.MinValue;
            foreach (var item in uniequeSubstrings)
            {
                maxLength = Math.Max(maxLength, item.Value);
            }
            string largestSubstring = string.Empty;

            foreach (var item in uniequeSubstrings)
            {
                if (item.Value == maxLength)
                    largestSubstring = item.Key;
            }
            Console.WriteLine(largestSubstring);
        }

        private void GenerateSubstringsRec(Dictionary<string, int> uniequeSubstrings,string input, int start, int end)
        {
            if (start == input.Length)
                return;
            else if (end == input.Length)
            {
                GenerateSubstringsRec(uniequeSubstrings,input, start + 1, start + 1);
                return;
            }

            HashSet<char> hs = new HashSet<char>();
            int charCount = 0;
            for (int i = start; i <= end; i++)
            {
                charCount++;
                //Console.Write(input[i]);
                if (hs.Contains(input[i]))
                    break; // if duplicate character is identified in current subArray, don't consider it
                hs.Add(input[i]);
            }

            char[] cArr = new char[hs.Count];
            hs.CopyTo(cArr, 0);
            string unqSubstr = new string(cArr);

            uniequeSubstrings.TryAdd(unqSubstr, charCount);

            //Console.WriteLine();
            GenerateSubstringsRec(uniequeSubstrings,input, start, end + 1);
        }
    }
}
