using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms
{
    public class LongestConsecutiveSequence
    {
        /// <summary>
        /// O(n^3)
        /// </summary>
        public void LongestConsecutiveSequenceBruteforce()
        {
            int[] arr = { 1, 9, 3, 0, 18, 5, 2, 4, 10, 7, 12, 6 };

            if (arr.Length == 0)
            {
                Console.WriteLine($"longestSequenceCount: 0");
                return;
            }

            int pointer = 0;
            int longestSequenceCount = 1;
            while (pointer < arr.Length)
            {
                int currentSequenceCount = 1;
                int i = 1;
                while(ArrayContains(arr, arr[pointer]+i))
                {
                    currentSequenceCount++;
                    i++;
                }
                longestSequenceCount = Math.Max(currentSequenceCount, longestSequenceCount);
                pointer++;
            }
            Console.WriteLine($"longestSequenceCount: {longestSequenceCount}");
        }

        private bool ArrayContains(int[] arr, int num)
        {
            int i = 0;
            while (i < arr.Length)
            {
                if (num == arr[i])
                    return true;
                i++;
            }
            return false;
        }

        /// <summary>
        /// O(nlogn)
        /// </summary>
        public void LongestConsecutiveSequenceWithSorting()
        {
            int[] arr = { 1, 9, 3, 0, 18, 5, 2, 4, 10, 7, 12, 6 };
            //int[] arr = { 1, 2, 3, 5, 6, 7, 8, 9 };


            if (arr.Length == 0)
            {
                Console.WriteLine($"longestSequenceCount: 0");
                return;
            }
            Array.Sort(arr);
            int pointer = 0;
            int longestSequenceCount = 1;
            int currentSequenceCount = 1;
            while (pointer < arr.Length - 1)
            {
                if (arr[pointer + 1] == arr[pointer] + 1)
                    currentSequenceCount++;
                else
                    currentSequenceCount = 1;
                longestSequenceCount = Math.Max(currentSequenceCount, longestSequenceCount);
                pointer++;
            }
            Console.WriteLine($"longestSequenceCount: {longestSequenceCount}");
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public void LongestConsecutiveSequenceWithoutSorting()
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
                /// if hashSet containts previous number,don't get into loop
                /// e.g: for input {1,2,3}, only for 1 there would be iteration with count 3 and for 2 & 3 the condition fails and
                /// does not get into the loop.
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
