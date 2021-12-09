using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.BinarySearch
{
    public class Pivot
    {
        public void FindPivot()
        {
            int[] arr = { 8, 10, 17, 1, 3 };
            // Here pivot can be 17 or 1. We consider 1 as pivot for this program.

            int start = 0;
            int end = arr.Length - 1;
            int mid = -1;

            while (start < end)
            {
                mid = start + (end - start) / 2;

                if (arr[mid] >= arr[0]) //for this example 17>8
                    start = mid + 1;
                else
                    end = mid;
            }
            Console.WriteLine($"Pivot element is {start}");//here we can use end as well as end=start
        }
    }
}
