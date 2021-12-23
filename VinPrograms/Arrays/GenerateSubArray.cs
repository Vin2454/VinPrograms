using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class GenerateSubArray
    {
        /// <summary>
        /// O(n^3)
        /// </summary>
        public void PrintSubArrayBruteForce()
        {
            int[] arr = { 1, 2, 3 };

            // Pick starting point
            for (int i = 0; i < arr.Length; i++)
            {
                // Pick ending point
                for (int j = i; j < arr.Length; j++)
                {
                    // Print subarray between current starting and ending points
                    for (int k = i; k <= j; k++) //here k<=j is important (include j)
                    {
                        Console.Write(arr[k] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Time Complexity: O(n^2)
        /// </summary>
        public void PrintSubArrayWithRecursion()
        {
            int[] arr = { 1, 2, 3 };
            PrintSubArrayRec(arr, 0, 0);
        }

        private void PrintSubArrayRec(int[] arr, int start, int end)
        {
            if (end == arr.Length)
                return;
            else if (start > end)
                PrintSubArrayRec(arr, 0, end + 1);
            else
            {
                Console.Write("[");
                for (int i = start; i < end; i++)
                {
                    Console.Write(arr[i] + ", ");
                }

                Console.WriteLine(arr[end] + "]");
                PrintSubArrayRec(arr, start + 1, end);
            }

            return;
        }
    }
}
