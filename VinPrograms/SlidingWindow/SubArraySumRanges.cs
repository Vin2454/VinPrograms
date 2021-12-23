using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.SlidingWindow
{
    public class SubArraySumRanges
    {
        public void SubArraySumForAGivenTarget_PrintAllTheRanges()
        {
            int[] arr = { 1,3,2,1,4,1,3,2,1,1,2};
            int target = 8;

            // Below is the sample Output
            // 2 5
            // 4 6
            // 5 9

            SumArraySumRangeWithRec(arr, 0, 0, target);
        }

        private void SumArraySumRangeWithRec(int[] arr, int start, int end, int target)
        {
            if (start == arr.Length)
                return;
            else if (end == arr.Length)
            {
                SumArraySumRangeWithRec(arr, start + 1, start + 1, target);
                return;
            }

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += arr[i];
                //Console.Write(arr[i] + ", ");
            }
            if (sum == target)
                Console.WriteLine($"index range:{start}-{end}");

            //Console.WriteLine();

            SumArraySumRangeWithRec(arr, start, end + 1, target);

            return;
        }
    }
}
