using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    /// <summary>
    /// For more ways: https://www.geeksforgeeks.org/count-ways-reach-nth-stair/
    /// </summary>
    public class ClimbingStairs
    {
        public void CountWaysToClimbStairs_With_1Or2Or3Steps()
        {
            int n = 4;
            // steps allowed 1 or 2 or 3

            // ***** To reach nth stair, total ways or f(n-1)+f(n-2)+f(n-3) which is recurrence relation

            Console.WriteLine(CountStepsWith1Or2Or3(n));
        }

        private int CountStepsWith1Or2Or3(int n)
        {
            if (n < 0)
                return 0;
            else if (n == 0) // jump at the same place, 1 way. It's bit confusing.
                return 1;
            else if (n == 1) // 1 step
                return 1;

            return CountStepsWith1Or2Or3(n-1)+ CountStepsWith1Or2Or3(n - 2)+ CountStepsWith1Or2Or3(n - 3);
        }
    }
}
