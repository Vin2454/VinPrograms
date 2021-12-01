using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms
{
    /// <summary>
    /// Array Length should be minimum 3
    /// </summary>
    public class TripletSum
    {
        /// <summary>
        /// O(n^3)
        /// </summary>
        public void PrintTriletSumBruteforce()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 };
            int target = 18;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == target)
                        {
                            Console.WriteLine($"Sum of triplet {arr[i]}, {arr[j]}, {arr[k]} is {target}");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// O(n^2), can try. But require to update PairSum class methods.
        /// </summary>
        public void PrintTriletSumUsingPairSum()
        {
            
        }

        /// <summary>
        /// O(n^2), space complexity O(n)
        /// </summary>
        public void PrintTriletSumUsingHashSet()
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 };
            //int target = 18;
            int[] arr = { 3,2,1 };
            int target = 6;

            for (int i = 0; i < arr.Length-2; i++)
            {
                HashSet<int> unorderedSet = new HashSet<int>();
                int targetPairSum = target - arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(unorderedSet.Contains(targetPairSum-arr[j]))
                    {
                        Console.WriteLine($"Sum of triplet {arr[i]}, {arr[j]}, {targetPairSum - arr[j]} is {target}");
                    }
                    unorderedSet.Add(arr[j]);
                }
            }
        }

        /// <summary>
        /// O(n^2), reduces space complexity and avoids to use DataStructure
        /// </summary>
        public void PrintTriletSumUsingSortingAnd2Pointers()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 };
            int target = 18;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 2; i++)
            {
                int left = i + 1;
                int right = arr.Length - 1;

                while (left < right)
                {
                    if (arr[i] + arr[left] + arr[right] == target)
                    {
                        Console.WriteLine($"Sum of triplet {arr[i]}, {arr[left]}, {arr[right]} is {target}");
                        left++;
                        right--;
                    }
                    else if (arr[i] + arr[left] + arr[right] < target)
                        left++;
                    else
                        right--;
                }
            }
        }
    } 
}
