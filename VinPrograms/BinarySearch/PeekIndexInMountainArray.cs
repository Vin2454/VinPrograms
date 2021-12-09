using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.BinarySearch
{
    public class PeekIndexInMountainArray
    {
        public void FindPeekIndexInMountainArray()
        {
            //int[] arr = { 3, 4, 5, 2 };
            int[] arr = { 0, 10, 5, 2 };

            int start = 0;
            int end = arr.Length - 1;
            int mid = -1;
            while (start < end) // Here, it must be start<end, should not be start<=end
            {
                mid = start + (end - start) / 2;

                if (arr[mid] < arr[mid + 1]) //left side of mountain
                    start = mid + 1;
                else
                    end = mid; // right side of mountain and peak. Here end is just mid, not mid-1
            }
            Console.WriteLine($"peak index in a mountain array is {start}");
        }
    }
}
