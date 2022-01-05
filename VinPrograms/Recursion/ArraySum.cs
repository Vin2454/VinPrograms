using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Recursion
{
    public class ArraySum
    {
        public void GetArraySum()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            //int sum = GetSum_Way1(arr, 0);
            //int sum = GetSum_Way2(arr, arr.Length - 1);
            int sum = GetSum_Way3(arr, arr.Length);

            Console.WriteLine(sum);
        }

        /// <summary>
        /// iterate from start to end and calculate with the current index
        /// </summary>
        private int GetSum_Way1(int[] arr, int i)
        {
            if (i >= arr.Length)
                return 0;
            int currenElement = arr[i];
            return currenElement + GetSum_Way1(arr, i + 1);
        }

        /// <summary>
        /// iterate from end-1 to start and calculate with the current index
        /// </summary>
        private int GetSum_Way2(int[] arr, int i)
        {
            if (i < 0)
                return 0;
            int currenElement = arr[i];
            return currenElement + GetSum_Way2(arr, i - 1);
        }

        /// <summary>
        /// iterate from end to start and calculate with the first element in each iteration
        /// </summary>
        private int GetSum_Way3(int[] arr, int i)
        {
            if (i <= 0)
                return 0;
            int currenElement = arr[i - 1];
            return currenElement + GetSum_Way3(arr, i - 1);
        }
    }
}
