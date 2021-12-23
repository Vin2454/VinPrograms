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
            PrintSubArrayRec2(arr, 0, 0);
        }

        /// <summary>
        ////Approach: We use two pointers start and end to maintain the starting and ending point of the array and follow the steps given below:
        ////Stop if we have reached the end of the array
        ////Increment the end index if start has become greater than end
        ////Print the subarray from index start to end and increment the starting index
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void PrintSubArrayRec(int[] arr, int start, int end)
        {
            if (end == arr.Length)
                return;
            else if (start > end)
                PrintSubArrayRec(arr, 0, end + 1);
            else
            {
                // To get below output
                //1,
                //1, 2,
                //2,
                //1, 2, 3,
                //2, 3,
                //3,
                for (int i = start; i <= end; i++) //Here i <= end
                {
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine();

                //// To get below output
                ////[1]                ////[1, 2]
                ////[2]
                ////[1, 2, 3]
                ////[2, 3]
                ////[3]

                //Console.Write("[");
                //for (int i = start; i < end; i++) // Here i < end only
                //{
                //    Console.Write(arr[i] + ", ");
                //}
                //Console.WriteLine(arr[end] + "]");


                PrintSubArrayRec(arr, start + 1, end);
            }

            return;
        }
        
        /// <summary>
        /// This is my thinking
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void PrintSubArrayRec2(int[] arr, int start, int end)
        {
            // To print below output. My thinking.
            //1,
            //1, 2,
            //1, 2, 3,
            //2,
            //2, 3,
            //3,

            if (start == arr.Length)
                return;
            else if (end == arr.Length)
            {
                PrintSubArrayRec2(arr, start + 1, start + 1);
                return; // Here return is important
            }

            for (int i = start; i <= end; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();

            PrintSubArrayRec2(arr, start, end + 1);

            return;
        }
    }
}
