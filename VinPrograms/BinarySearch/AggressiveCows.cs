using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.BinarySearch
{
    /// <summary>
    /// EVEN THOUGH IT LOOKS LIKE ARRANGEMENT, IT IS BASICALLY PLACING/SELECTION OF R COWS IN N STALLS. SO FORMULA IS NCR
    /// Similar problems
    //1552. Magnetic Force Between Two Balls
    //1870. Minimum Speed to Arrive on Time
    //875. Koko Eating Bananas
    //1011. Capacity To Ship Packages Within D Days
    //1283. Find the Smallest Divisor Given a Threshold
    //1482. Minimum Number of Days to Make m Bouquets
    //2064. Minimized Maximum of Products Distributed to Any Store
    //1231 Divide Chocolate
    //774 Minimize Max Distance to Gas Station
    //410 Split Array Largest Sum
    /// </summary>
    public class AggressiveCows
    {
        public void AggressiveCowsSolve()
        {
            int[] stalls = { 1, 2, 4, 8, 9 };
            int giventCows = 3;
            
            //int[] stalls = { 4, 2, 1, 3, 6 };
            //int giventCows = 2;

            //int start = 1; //this will not work if we start from 0. Because of end value
            //int end = stalls[stalls.Length - 1] - stalls[0]; // assuming array is sorted. If not, need to sort the array

            int start = 0; //this works now
            int end = int.MaxValue;

            int mid = -1;
            int answer = -1;

            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (canPlaceCows(stalls, giventCows, mid)) //If I can place cows by keeping mid as minimum distance, it's a valid answer.
                {
                    answer = mid;
                    start = mid + 1;
                }
                else
                    end = mid - 1;
            }
            Console.WriteLine($"Largest minimum distance between any 2 cows is {answer}");
        }

        private bool canPlaceCows(int[] stalls,int givenCows, int minimumDistance)
        {
            // place first cow at position 0
            int lastCowPosition = stalls[0];
            int cowsCount = 1;

            int stallIndex = 1;
            while (stallIndex<stalls.Length)
            {
                if(stalls[stallIndex]-lastCowPosition>=minimumDistance)
                {
                    cowsCount++;
                    lastCowPosition = stalls[stallIndex];
                }
                
                stallIndex++;
            }

            if (cowsCount == givenCows)
                return true;
            return false;
        }
    }
}
