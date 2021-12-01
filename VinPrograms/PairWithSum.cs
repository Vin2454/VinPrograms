using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms
{
    public class PairWithSum
    {
        /// <summary>
        /// O(n^2)
        /// </summary>
        public void PrintPairWithSumBruteforce()
        {
            int[] array = { 10, 5, 2, 3, -6, 9, 11 };
            int target = 5;
            int i = 0;
            while (i < array.Length - 1)
            {
                int j = i + 1;
                while (j < array.Length)
                {
                    if (array[i] + array[j] == target)
                    {
                        Console.WriteLine($"Sum of pair {array[i]} & {array[j]} is {target}");
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
            int[] array = { 10, 5, 2, 3, -6, 9, 11 };
            int target = 5;
            Array.Sort(array);//{-6,2,3,5,9,10,11}

            int i = 0;
            while (i < array.Length)
            {
                int key = target - array[i];
                if (BinarySearch(array, key) != -1)
                {
                    Console.WriteLine($"Sum of pair {array[i]} & {key} is {target}");
                }
                i++;
            }
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public void PrintPairWithSumWithoutSortingAndUsingHashSet()
        {
            int[] array = { 1, 2, 3, 2 };
            int target = 4;

            HashSet<int> unorderedSet = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!unorderedSet.Contains(target - array[i]))
                {
                    unorderedSet.Add(array[i]);
                }
                else
                    Console.WriteLine($"Sum of pair {array[i]} & {target - array[i]} is {target}");
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
