using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    public class MaxSumSubArrayOfSizeK
    {
        /// <summary>
        /// Time Complexity: O(n^2)
        /// </summary>
        public void FindMaxSumSubArrayOfSizeK_BruteForce()
        {
            int[] arr = { 5, -3, 3, 2 };
            int k = 2;//subArray size

            int i = 0;
            int maxSum = int.MinValue;
            while (i < arr.Length - k + 1)
            {
                int j = i;
                int currentSubArraySum = 0;
                while (j < i + k) // since subArray size is k
                {
                    currentSubArraySum += arr[j];
                    j++;
                }
                maxSum = Math.Max(maxSum, currentSubArraySum);

                i++;
            }
            Console.WriteLine($"Maximum sum of subarray of size {k} is {maxSum}");
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// Video Explanation: https://www.youtube.com/watch?v=KtpqeN0Goro&list=PL_z_8CaSLPWeM8BDJmIYDaoQ5zuwyxnfj&index=3
        /// </summary>
        public void FindMaxSumSubArrayOfSizeK_WithSlidingWindow()
        {
            int[] arr = { 100, 200, 300, 400 };
            int k = 2;
            // expected output: 700

            //int[] arr = { 1, 4, 2, 10, 23, 3, 1, 0, 20 };
            //int k = 4;
            //// expected output: 39

            int start = 0;
            int end = 0;

            int maxSum = int.MinValue;
            int currentSubArraySum = 0;

            while (end<arr.Length)
            {
                currentSubArraySum += arr[end];
                int windowSize = end - start + 1;

                if (windowSize < k) //  till windowSize reached for the first time
                    end++;
                if(windowSize==k)
                {
                    maxSum = Math.Max(maxSum, currentSubArraySum);

                    currentSubArraySum -= arr[start]; //it's important to remove pre-element first before incrementing the start

                    start++;
                    end++;
                }
            }
            Console.WriteLine($"Maximum sum of subarray of size {k} is {maxSum}");
        }
    }
}
