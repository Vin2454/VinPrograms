using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class ShortestUnsortedSubArray
    {
        /// <summary>
        /// o(nlogn)
        /// </summary>
        public void FindUnsortedSubarrayBrueforceWithSorting()
        {
            int[] nums = { 1, 2, 3, 4, 5, 8, 6, 7, 9, 10, 11 };
            //int[] nums = { 2, 6, 4, 8, 10, 9, 15 };
            //int[] nums = { 1, 2, 3, 4 };
            //int[] nums = { 1 };

            int[] sortedNums = new int[nums.Length];
            Array.Copy(nums, sortedNums, nums.Length);
            Array.Sort(sortedNums); // O(nlogn)

            int start = 0;
            int end = nums.Length - 1;
            int pointer = 0;
            while (pointer < nums.Length - 1)
            {
                if (nums[start] == sortedNums[start])
                    start++;
                if (nums[end] == sortedNums[end])
                    end--;
                //// if we use below the start index & end index increments and decrements respectively and we will not
                /// get expected index values. so need to have 2 seperate while loops for getting start & end indexes or use
                /// one pointer and iterate from 0 to n-1
                //if(nums[start] != sortedNums[start] && nums[end] != sortedNums[end])
                //{
                //    start++;
                //    end--;
                //}
                pointer++;
            }
            if (start == nums.Length - 1)
            {
                Console.WriteLine($"starting index: {-1}; ending index: {-1}");
                return;
            }
            Console.WriteLine($"starting index: {start}; ending index: {end}");
        }

        /// <summary>
        /// o(n)
        /// </summary>
        public void FindUnsortedSubarrayWithoutSortingIncorrectThoughtProcess()
        {
            int[] nums = { 1, 2, 3, 4, 5, 8, 6, 7, 9, 10, 11 };
            // Thought about the logic as current should be greater than previous and less than next
            // But for above start value shouldbe 8 and endvalue should be 7 for which indexes are 5 & 7 respectively.
            // But with my thought process from the right side 7(current) greater than previous(6) and less than 10(next). 
            // So it gives value 6 with index 6 instead of value 7 with index 7


            //int[] nums = { 2, 6, 4, 8, 10, 9, 15 };
            //int[] nums = { 1, 2, 3, 4 };

            int startPointer = 1;
            int endPointer = nums.Length - 2;
            while (startPointer < nums.Length - 1)
            {
                if (nums[startPointer] < nums[startPointer - 1] || nums[startPointer] > nums[startPointer + 1])
                {
                    break;
                }
                startPointer++;
            }
            while (endPointer > 0)
            {
                if (nums[endPointer] < nums[endPointer - 1] || nums[endPointer] > nums[endPointer + 1])
                {
                    break;
                }
                endPointer--;
            }

            Console.WriteLine($"starting index: {startPointer}; ending index: {endPointer}");
        }

        /// <summary>
        /// o(n)
        /// </summary>
        public void FindUnsortedSubarrayWithoutSortingCorrectThoughtProcess()
        {
            int[] nums = { 1, 2, 3, 4, 5, 8, 6, 7, 9, 10, 11 };
            //int[] nums = { 2, 6, 4, 8, 10, 9, 15 };
            //int[] nums = { 1, 2, 3, 4 };
            //int[] nums = { 1 }; // exception to be handled here

            int smallest = int.MaxValue;
            int largest = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                if (IsOutOfOrder(nums, i))
                {
                    smallest = Math.Min(smallest, current);
                    largest = Math.Max(largest, current);
                    Console.WriteLine($"smallest:{smallest} largest:{largest}");
                }
            }
            if (smallest == int.MaxValue)
            {
                Console.WriteLine($"starting index: {-1}; ending index: {-1}");
                return;
            }

            int left = 0;
            while (smallest >= nums[left])
            {
                left++;
            }
            int right = nums.Length - 1;
            while (largest <= nums[right])
            {
                right--;
            }
            Console.WriteLine($"starting index: {left}; ending index: {right}");
        }
        private bool IsOutOfOrder(int[] arr, int i)
        {
            int current = arr[i];

            // edge cases
            if (i == 0)
                return current > arr[1];
            if (i == arr.Length - 1)
                return current < arr[i - 1];

            int previous = arr[i - 1];
            int next = arr[i + 1];
            
            return current < previous || current > next;
        }
    }
}
