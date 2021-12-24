using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    public class FirstNegativeNumberInEveryWindowOfSizeK
    {
        /// <summary>
        /// Time Complexity: O(n^2)
        /// </summary>
        public void PrintFirstNegativeNumberInEveryWindowOfSizeK_BruteForce()
        {
            int[] arr = { 12, -1, -7, 8, -15, 30, 16, 28 };
            int k = 3;

            //int[] arr = { -8, 2, 3, -6, 10 };
            //int k = 2;

            int start = 0;
            int end = 0;

            while (end < arr.Length) //important to remember this instead of start condition
            {
                end = start;
                int firstNegativeNumber = 0;
                while (end < start + k)
                {
                    if (arr[end] < 0)
                    {
                        firstNegativeNumber = arr[end];
                        break;
                    }
                    end++;
                }

                Console.WriteLine($"First negative number in the window from {arr[start]} to {arr[start + k - 1]} is {firstNegativeNumber}");
                start++;
            }
        }

        /// <summary>
        /// Time Complexity: O(n), Space Complexity: O(k)
        /// Video Explanation: https://www.youtube.com/watch?v=uUXXEgK2Jh8&list=PL_z_8CaSLPWeM8BDJmIYDaoQ5zuwyxnfj&index=4
        /// Solution with Space Complexity O(1) is available @ https://www.geeksforgeeks.org/first-negative-integer-every-window-size-k/
        /// </summary>
        public void PrintFirstNegativeNumberInEveryWindowOfSizeK_SlidingWindow()
        {
            int[] arr = { 12, -1, -7, 8, -15, 30, 16, 28 };
            int k = 3;
            //int[] arr = { -8, 2, 3, -6, 10 };
            //int k = 2;

            int start = 0;
            int end = 0;

            List<int> negativeNumbers = new List<int>();

            while (end < arr.Length)
            {
                int windowSize = end - start + 1;
                int firstNegativeNumber = 0;

                if (arr[end] < 0)
                    negativeNumbers.Add(arr[end]);

                if (windowSize < k)
                    end++;

                else if (windowSize == k)
                {
                    if (negativeNumbers.Count > 0)
                    {
                        firstNegativeNumber = negativeNumbers[0];

                        Console.WriteLine($"First negative number in the window from {arr[start]} to {arr[start + k - 1]} is {firstNegativeNumber}");
                        // It's important that the above statement should be first before we increment start & end

                        if (arr[start] == firstNegativeNumber) // This is very important checck, otherwise same -ve number cannot get into multiple windows
                            negativeNumbers.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine($"First negative number in the window from {arr[start]} to {arr[start + k - 1]} is {firstNegativeNumber}");
                    }

                    start++;
                    end++;
                    // The above 2 statements are responsible for changing the current window
                }
            }
        }
    }
}
