using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class MoveZerosToEnd
    {
        /// <summary>
        /// Output: 12 1 3 0 0
        /// </summary>
        public void MovingZerosToEndMethodIncorrectMethod()
        {
            int[] arr = { 0, 1, 0, 3, 12 };

            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                if (arr[start] == 0)
                {
                    Swap(arr, start, end);
                    end--;
                }
                start++;
            }
            PraintArray(arr);
        }

        /// <summary>
        /// Question is to shift zeros to right, but we are shifting non-zeros to left
        /// Think to fix non-zeros, instead of thinking to fix zeros
        /// 1 3 12 0 0
        /// </summary>
        public void MovingZerosToEndCorrectMethod()
        {
            int[] arr = { 0, 1, 0, 3, 12 };
            //int[] arr = { 0, 1};

            int i = 0;
            int j = 0;
            while (j < arr.Length)
            {
                if (arr[j] != 0)
                {
                    Swap(arr, i, j);
                    i++;
                }
                j++;
            }

            PraintArray(arr);
        }

        private void Swap(int[] arr, int start, int end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
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
