using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class ShortestUnsortedSubArray
    {
        public void FindUnsortedSubarrayBrueforce()
        {
            int[] nums = { 1,2,3,4 };
            //int[] nums = { 2, 6, 4, 8, 10, 9, 15 };
            //int[] nums = { 1,2,3,4,5,8,6,7,9,10,11 };

            int[] sortedNums = new int[nums.Length];
            Array.Copy(nums, sortedNums, nums.Length);
            Array.Sort(sortedNums); // O(nlogn)

            int start = 0;
            int end = nums.Length - 1;
            int pointer = 0;
            while (pointer<nums.Length-1)
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
    }
}
