using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class CheckIfSortedRotatedArray
    {
        /// <summary>
        /// In a Sorted and rotated array, we can always find only one pair arr[i-1]>arr[i], think array as a circular
        /// </summary>
        public void CheckIfAnArrayIsSortedAndRotated()
        {
            //int[] arr = { 3, 4, 5, 1, 2 }; //True
            //int[] arr = { 2, 1, 3, 4 }; //False
            int[] arr = { 1,1,1};

            int n = arr.Length;
            int count = 0;
            int i = 1; //since we are comparing from i-1
            while (i < arr.Length)
            {
                if (arr[i - 1] > arr[i])
                    count++;
                i++;
            }

            if (arr[n - 1] > arr[0])
                count++;

            Console.WriteLine(count <= 1); //if only count == 1 used, { 1,1,1} will return false, expected true
        }
    }
}
