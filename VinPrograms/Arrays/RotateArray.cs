using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class RotateArray
    {
        /// <summary>
        /// Modulus of any number x is always between 0 and n-1
        /// formula: arr[(i+k)%n]=arr[i]
        /// </summary>
        public void RotateAnArrayByKstepsWithFormula()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            int[] temp = new int[(nums.Length)];

            int i = 0;
            while (i < nums.Length)
            {
                temp[(i + k) % nums.Length] = nums[i];
                i++;
            }
            nums = temp;

            PraintArray(nums);
        }
        private static void PraintArray(int[] arr)
        {
            int p = 0;
            while (p < arr.Length)
            {
                Console.Write(arr[p] + " ");
                p++;
            }
        }
    }
}
