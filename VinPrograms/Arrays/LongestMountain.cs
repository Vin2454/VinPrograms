using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms
{
    public class LongestMountain
    {
        /// <summary>
        /// O(n+n)==> O(n). It looks like O(n^2). But actually it is O(n) only.
        /// Array length should be minimum 3. There should be atleast one element before the peak
        /// and one element after the peak. So we should start from i=1 and end at i=n-1
        /// </summary>
        public void PrintLongestMountainMethod1()
        {
            //int[] arr = {5,6,1,2,3,4,5,4,3,2,0,1,2,3,-2,4 };
            int[] arr = { 1, 2, 3, 2, 1, 0, 2, 3, 1 };
            int i = 1;
            int highestPeak = 0;
            while (i < arr.Length - 1)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    int currentPeak = 0;

                    int j = i;
                    while (j > 0 && arr[j] > arr[j - 1])
                    {
                        currentPeak++;
                        j--;
                    }
                    // For backward count, we use another pointer j for the iteration and for the forward count
                    // we use the same pointer i
                    while (i < arr.Length - 1 && arr[i] > arr[i + 1])
                    {
                        currentPeak++;
                        i++;
                    }
                    highestPeak = Math.Max(highestPeak, currentPeak);
                }
                i++;
            }
            Console.WriteLine($"Highest Peak is { highestPeak}");
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public void PrintLongestMountain2PointerApproach()
        {
            //int[] arr = {5,6,1,2,3,4,5,4,3,2,0,1,2,3,-2,4 };
            int[] arr = { 1, 2, 3, 2, 1, 0, 2, 3, 1 };
            int i = 1;
            int highestPeak = 0;
        }
    }
}
