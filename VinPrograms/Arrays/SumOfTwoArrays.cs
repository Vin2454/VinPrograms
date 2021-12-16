using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class SumOfTwoArrays
    {
        /// <summary>
        /// Need to use mod(%) and coefficient
        /// </summary>
        public void FindArraySum()
        {
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 99 };

            int[] arr1 = { 1, 2, 3,4 };
            int[] arr2 = { 6 };

            // 3 cases possible
            //case 1: left array bigger: arr1={1,2,3,4}, arr2={6}
            //case 2: right array bigger: arr1={6}, arr2={1,2,3,4}
            //case 3: after sum carry, need additional elements arr1={9,9,9}, arr2={9,9,9}

            int i = arr1.Length-1;
            int j = arr2.Length - 1;
            int carry = 0;
            List<int> ans = new List<int>();
            while (i >= 0 && j >= 0)
            {
                int val1 = arr1[i];
                int val2 = arr2[j];

                int sum = val1 + val2 + carry;

                carry = sum / 10;
                sum = sum % 10;
                ans.Add(sum);
                i--;
                j--;
            }

            //case1
            while (i>=0)
            {
                int sum = arr1[i] + carry;
                carry = sum / 10;
                sum = sum % 10;
                ans.Add(sum);
                i--;
            }
            //case2
            while (j >= 0)
            {
                int sum = arr2[j] + carry;
                carry = sum / 10;
                sum = sum % 10;
                ans.Add(sum);
                j--;
            }

            //case3
            while (carry!=0)
            {
                int sum = carry;
                carry = sum / 10;
                sum = sum % 10;
                ans.Add(sum);
            }
            ans.Reverse(); //this is required and important

            PraintArray(ans.ToArray());
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
