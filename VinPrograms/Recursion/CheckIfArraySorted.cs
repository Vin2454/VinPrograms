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
            else
            {
                return CheckStrictArraySorting(arr, i + 1);
            }
        }
    }
}
