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
    }
}
