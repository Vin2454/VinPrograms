using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    /// <summary>
    /// Given an array arr[] of size N and an integer K. 
    /// Find the maximum for each and every contiguous subarray of size K.
    /// </summary>
    public class MaximumOfAllSubArraysOfSizeK
    {
        /// <summary>
        /// Time Complexity: O(n^2)
        /// </summary>
        public void MaxOfAllSubArraysOfSizeK_BruteForce()
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            //expected output: 3, 3, 5, 5, 6, 7

            if (k > arr.Length)
            {
                Console.WriteLine("we can return maximum in the given array");
                return;
            }

            int start = 0;
            while (start < arr.Length - k)
            {
                int end = start;
                int maximumInCurrentSubArray = int.MinValue;
                while (end < start + k)
                {
                    maximumInCurrentSubArray = Math.Max(maximumInCurrentSubArray, arr[end]);
                    end++;
                }
                Console.WriteLine($"Maximum value in current SubArray is { maximumInCurrentSubArray}");
                start++;
            }
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// Aditya Verma Video: https://www.youtube.com/watch?v=xFJXtB5vSmM&list=PL_z_8CaSLPWeM8BDJmIYDaoQ5zuwyxnfj&index=6
        /// </summary>
        public void MaxOfAllSubArraysOfSizeK_WithSlidingWindow()
        {
            //int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            //int k = 3;
            ////// expected output: 3, 3, 5, 5, 6, 7

            //// below test case fails
            //int[] arr = { 2,1 };
            //int k = 1;
            
            // below test case fails
            int[] arr = { 6, 3, 4, 1, 1, 2, 5, 6 };
            int k = 3;

            if (k > arr.Length)
            {
                Console.WriteLine("we can return maximum in the given array");
                return;
            }

            //int start = 0;

            int start = 0;
            int end = 0;
            List<int> maxElements = new List<int>();
            int maxElementInCurrentWindow = int.MinValue;

            int maximumInSubArray = int.MinValue;

            while (end<arr.Length)
            {
                int windowSize = end - start + 1;
                // Calculations
                maximumInSubArray = Math.Max(maximumInSubArray, arr[end]);

                if (windowSize < k)
                    end++;

                if(windowSize==k)
                {
                    // get the answer <- calculation
                    Console.WriteLine($"Maximum value in current SubArray is { maximumInSubArray}");

                    // slide the window and remove start element
                    start++;
                    end++;
                }
            }
            
        }
    }
}
