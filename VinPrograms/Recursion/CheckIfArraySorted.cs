using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Recursion
{
    public class CheckIfArraySorted
    {
        public void CheckIfArrayStrictlySortedRec()
        {
            int[] arr = { 1,2,3,4,4,8 };
            Console.WriteLine(CheckStrictArraySorting(arr, 0));
            Console.WriteLine(CheckStrictArraySortingApproach2(arr,arr.Length));
            Console.ReadLine();
        }

        private bool CheckStrictArraySorting(int[] arr, int i)
        {
            if(i==arr.Length-1)
            {
                return true;
            }

            if (arr[i] >= arr[i + 1])
            {
                return false;
            }
            return CheckStrictArraySorting(arr, i + 1);
        }

        private bool CheckStrictArraySortingApproach2(int[] arr, int i)
        {
            // Array has one or no element or the
            // rest are already checked and approved.
            if (i == 1 || i == 0)
                return true;

            // Unsorted pair found (Equal values allowed)
            if (arr[i - 1] < arr[i - 2])
                return false;

            // Last pair was sorted
            // Keep on checking
            return CheckStrictArraySortingApproach2(arr, i - 1);
        }
    }
}
