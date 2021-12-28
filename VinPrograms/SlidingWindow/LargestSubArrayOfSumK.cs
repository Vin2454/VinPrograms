using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    /// <summary>
    /// Variable window size sliding window
    /// This sliding window works only for positive integers. If the array contains negative integers, need to
    /// use different solution (use HashMap)
    /// </summary>
    public class LargestSubArrayOfSumK
    {
        public void LargestSubArrayOfSumK_WithSlidingWindow_OnlyForPositiveIntegers()
        {
            int[] arr = { 4 ,1 ,1, 1 ,2, 3 ,5 };
            int k = 5;
            // expected output 4 (1+1+1+2=5)

            int start = 0;
            int end = 0;
            
            int subArraySum = 0;
            int maxSubArrayLength = 0;
            while (end < arr.Length)
            {
                // Calculations
                subArraySum += arr[end];

                if (subArraySum < k)
                    end++;

                else if (subArraySum == k)
                {
                    // get the answer <- calculation
                    maxSubArrayLength = Math.Max(maxSubArrayLength, end - start + 1);
                    end++;
                }
                else if (subArraySum > k)
                {
                    while (subArraySum > k)
                    {
                        // Remove calculations for start
                        subArraySum -= arr[start];
                        start++;
                    }
                    end++;
                }
            }
            Console.WriteLine($"Max SubArray Length is {maxSubArrayLength}");
        }
    }
}
