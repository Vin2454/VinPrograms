using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms
{
    /// <summary>
    /// Array Length should be minimum 2
    /// </summary>
    public class PairSum
    {
        /// <summary>
        /// O(n^2)
        /// </summary>
        public void PrintPairWithSumBruteforce()
        {
            int[] arr = { 10, 5, 2, 3, -6, 9, 11 };
            int target = 5;
            int i = 0;
            while (i < arr.Length - 1)
            {
                int j = i + 1;
                while (j < arr.Length)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"Sum of pair {arr[i]} & {arr[j]} is {target}");
                        break;
                    }
                    j++;
                }
                i++;
            }
        }

        /// <summary>
        /// O(nlogn)
        /// </summary>
        public void PrintPairWithSumWithSortingAndBinarySearch()
        {
            int[] arr = { 10, 5, 2, 3, -6, 9, 11 };
            int target = 5;
            Array.Sort(arr);//{-6,2,3,5,9,10,11}

            int i = 0;
            while (i < arr.Length)
            {
                int key = target - arr[i];
                if (BinarySearch(arr, key) != -1)
                {
                    Console.WriteLine($"Sum of pair {arr[i]} & {key} is {target}");
                }
                i++;
            }
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public void PrintPairWithSumWithoutSortingAndUsingHashSet()
        {
            int[] arr = { 1, 2, 3, 2 };
            int target = 4;

            HashSet<int> unorderedSet = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!unorderedSet.Contains(target - arr[i]))
                {
                    unorderedSet.Add(arr[i]);
                }
                else
                    Console.WriteLine($"Sum of pair {arr[i]} & {target - arr[i]} is {target}");
            }
        }

        private int BinarySearch(int[] arr, int key)
        {
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
