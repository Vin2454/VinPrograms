using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.BinarySearch
{
    public class SearchElementInSortedRoatedArray
    {
        /// <summary>
        /// 1) Find Pivot and 2) Based on condition, binary search in respective line of elements
        /// </summary>
        public void SearchElementInSortedAndRoatedArray()
        {
            int[] arr = { 7, 8, 1, 2, 3 };
            int key = 1;

            int keyAtIndex = -1;
            int size = arr.Length;
            int pivot = FindPivot(arr);
            if (key >= arr[pivot] && key <= arr[size - 1])
                keyAtIndex = BinarySearchBasic(arr, key, pivot, size - 1);
            else
                keyAtIndex = BinarySearchBasic(arr, key, 0, pivot - 1);

            Console.WriteLine($"Key {key} found at index {keyAtIndex}");
        }

        public int FindPivot(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid = -1;

            while (start < end)
            {
                mid = start + (end - start) / 2;

                if (arr[mid] >= arr[0]) 
                    start = mid + 1;
                else
                    end = mid;
            }
            return start;
        }

        public int BinarySearchBasic(int[] arr,int key, int start, int end)
        {
            while (start <= end)
            {
                int middle = start + (end - start) / 2;

                if (key == arr[middle])
                {
                    return middle;
                }
                else if (key < arr[middle])
                    end = middle - 1;
                else
                    start = middle + 1;
            }
            return -1;
        }
    }
}
