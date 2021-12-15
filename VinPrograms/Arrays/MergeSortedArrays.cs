using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class MergeSortedArrays
    {
        public void MergeTwoSortedArrays()
        {
            int[] arr1 = { 1,3,5,7,9};
            int[] arr2 = { 2, 5, 6 };

            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i<arr1.Length && j<arr2.Length)
            {
                if(arr1[i]<arr2[j])
                {
                    arr3[k] = arr1[i];
                    i++;
                }
                else if (arr2[j] < arr1[i])
                {
                    arr3[k] = arr2[j];
                    j++;
                }

                // if we need to include duplicates
                //else
                //{
                //    arr3[k] = arr1[i];
                //    i++;
                //    k++;
                //    arr3[k] = arr2[j];
                //    j++;
                //}

                // if we need to exclude duplicates. But at the end Zero(0) will be printed
                else
                {
                    arr3[k] = arr1[i];
                    i++;
                    j++;
                }

                k++;
            }

            while (k < arr3.Length)
            {
                if (i < arr1.Length)
                {
                    arr3[k] = arr1[i];
                    i++;
                }
                else if (j < arr2.Length)
                {
                    arr3[k] = arr2[j];
                    j++;
                }

                k++;
            }

            PraintArray(arr3);
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
