using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    public class SubArraySumRanges
    {
        /// <summary>
        /// O(n^2)
        /// </summary>
        public void SubArraySumForAGivenTarget_PrintAllTheRanges_WithRecursion()
        {
            int[] arr = { 1, 3, 2, 1, 4, 1, 3, 2, 1, 1, 2 };
            int target = 8;

            // Below is the sample Output
            // 2 5
            // 4 6
            // 5 9

            SumArraySumRangeWithRec_MyMethod(arr, 0, 0, target);
        }

        private void SumArraySumRangeWithRec_MyMethod(int[] arr, int start, int end, int target)
        {
            if (start == arr.Length)
                return;
            else if (end == arr.Length)
            {
                SumArraySumRangeWithRec_MyMethod(arr, start + 1, start + 1, target);
                return;
            }

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += arr[i];
                //Console.Write(arr[i] + ", ");
            }
            if (sum == target)
                Console.WriteLine($"index range:{start}-{end}");

            //Console.WriteLine();

            SumArraySumRangeWithRec_MyMethod(arr, start, end + 1, target);

            return;
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public void SubArraySumForAGivenTarget_PrintAllTheRanges_WithSlidingWindow()
        {
            int[] arr = { 1, 3, 2, 1, 4, 1, 3, 2, 1, 1, 2 };
            int target = 8;

            // Below is the sample Output
            // 2 5
            // 4 6
            // 5 9

            int i = 0;
            int j = 0;
            int currentSum = 0;

            while (j < arr.Length)
            {
                // expand to right
                currentSum += arr[j];
                j++;

                // remove elements from left till currentSum>target and i<j
                while (currentSum > target && i < j)
                {
                    currentSum = currentSum - arr[i];
                    i++;
                }

                // check if any given point
                if (currentSum == target)
                    // print the window
                    Console.WriteLine($"index range:{i}-{j - 1}");// j-1 since we have incremented j above and it will go to next position
            }
        }
    }
}
