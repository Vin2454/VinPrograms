using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class SortedOrUnSorted
    {
        public void SortedOrNotUsingRecursion()
        {
            int[] arr = { 1, 3, 5, 8, 9, 15 };
            //int[] arr = { 1, 3, 5, 2, 9, 15 };

            if (arr.Length < 2)
                return;

            Console.WriteLine(SortedOrNotRec(arr, 1));
        }

        private bool SortedOrNotRec(int[] arr, int i)
        {
            //Traversed entire array. 
            //This conditions should be checked first instead of next. Otherwise, arr[i] will throw exception
            //We should check i greater than equal to array length. If equals not used used it will go to next statement will throw exception at arr[i]
            if (i >= arr.Length)
                return true;

            int current = arr[i];
            int previous = arr[i - 1];

            if (current < previous)
                return false;

            return SortedOrNotRec(arr, i + 1);
        }

        public void SortedOrNotUsingRecursion_OtherMethod()
        {
            int[] arr = { 20, 23, 23, 45, 78, 88 };
            int n = arr.Length;
            if (ArraySortedOrNot(arr, n) != 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        static int ArraySortedOrNot(int[] arr, int n)
        {
            // Array has one or no element or the
            // rest are already checked and approved.
            if (n == 1 || n == 0)
                return 1;

            // Unsorted pair found (Equal values allowed)
            if (arr[n - 2] > arr[n - 1])
                return 0;

            // Last pair was sorted
            // Keep on checking
            return ArraySortedOrNot(arr, n - 1);
        }
    }
}
