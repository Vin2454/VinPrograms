using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class TrappingRainWater
    {
        public void Trap()
        {
            int[] heights = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            if (heights.Length < 3)
                Console.WriteLine("No water trapped");

            int water = 0;
            int n = heights.Length;
            int[] leftMax = new int[n];
            leftMax[0] = heights[0];

            int[] rightMax = new int[n];
            rightMax[n - 1] = heights[n - 1];

            for (int i = 1; i < n; i++)
            {
                int leftMaxValue = Math.Max(heights[i], leftMax[i - 1]);
                leftMax[i] = leftMaxValue;
            }

            for (int i = n - 2; i >= 0; i--)
            {
                int rightMaxValue = Math.Max(heights[i], rightMax[i + 1]);
                rightMax[i] = rightMaxValue;
            }

            // The real water level is min of highest water from the left 
            // and highest water from the right subtract the building's high (if any) 
            // from under neath.
            for (int i = 0; i < n - 1; ++i)
            {
                water += Math.Min(leftMax[i], rightMax[i]) - heights[i];
            }

            Console.WriteLine($"water trapped: {water}");
        }
    }
}
