using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Sortings
{
    public class SelectionSort
    {
        /// <summary>
        /// Worst case Time complexity: o(n*n), Space complexity: o(1)
        /// Smallest will be sorted&fixed first
        /// Use case: When array size is small
        /// Not a stable algorithm
        /// </summary>
        public void ApplySelectionSort()
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            int i = 0;

            while (i < arr.Length - 1)
            {
                int currentIndex = i + 1;
                int minimumIndex = i;

                while (currentIndex < arr.Length)
                {
                    if (arr[currentIndex] < arr[minimumIndex])
                    {
                        minimumIndex = currentIndex;
                    }
                    currentIndex++;
                }

                Swap(arr, i, minimumIndex);

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

        //private void swap(int a, int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        
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
