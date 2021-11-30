using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms
{
    public class LongestConsecutiveSubsequence
    {
        public void LongestSubSequenceWithSorting()
        {
            int[] arr = { 1, 9, 3, 0, 18, 5, 2, 4, 10, 7, 12, 6 };

            if (arr.Length == 0)
            {
                Console.WriteLine($"longestSequenceCount: 0");
                return;
            }
            Array.Sort(arr);
            int pointer = 0;
            int longestSequenceCount = 0;
            int currentSequenceCount = 0;
            while (pointer < arr.Length - 1)
            {
                if (arr[pointer + 1] == arr[pointer] + 1)
                    currentSequenceCount++;
                longestSequenceCount = Math.Max(currentSequenceCount, longestSequenceCount);
                pointer++;
            }
            Console.WriteLine($"longestSequenceCount: {longestSequenceCount}");
        }
        public void LongestSubSequenceWithoutSorting()
        {
            int[] arr = { 1, 9, 3, 0, 18, 5, 2, 4, 10, 7, 12, 6 };
            if (arr.Length == 0)
            {
                Console.WriteLine($"longestSequenceCount: 0");
                return;
            }

            HashSet<int> unorderedSet = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                unorderedSet.Add(arr[i]);
            }

            int longestSequenceCount = 0;

            foreach (int num in unorderedSet)
            {
                if (!unorderedSet.Contains(num - 1))
                {
                    int currentNumber = num;
                    int currentSequenceCount = 1;

                    while (unorderedSet.Contains(currentNumber + 1))
                    {
                        currentNumber++;
                        currentSequenceCount++;
                    }

                    longestSequenceCount = Math.Max(currentSequenceCount, longestSequenceCount);
                }
            }
            Console.WriteLine($"longestSequenceCount: {longestSequenceCount}");
        }
    }
}
