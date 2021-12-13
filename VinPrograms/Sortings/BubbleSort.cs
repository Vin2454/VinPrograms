using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Sortings
{
    /// <summary>
    /// Time complexity: o(n*n), Space complexity: o(1)
    /// But best case time complexity is o(n)
    /// Largest will be sorted &fixed first
    /// Use case: In each i'th round, i'th largest element will be identified
    /// A stable algorithm
    /// </summary>
    public class BubbleSort
    {
        public void ApplyBubbleSort()
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            int i = 0;
            while (i < arr.Length - 1)
            {
                int currentIndex = 0;
                while (currentIndex < arr.Length - 1 - i)
                {
                    if (arr[currentIndex] > arr[currentIndex + 1])
                        Swap(arr, currentIndex, currentIndex + 1);

                    currentIndex++;
                }

                i++;
            }

            PraintArray(arr);
        }

        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[b];
            arr[b] = arr[a];
            arr[a] = temp;
        }

        private static void PraintArray(int[] arr)
        {
            int p = 0;
            while (p < arr.Length)
            {
                Console.Write(arr[p] + " ");
                p++;
            }
        }
    }
}
