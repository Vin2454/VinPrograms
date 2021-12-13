using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Sortings
{
    /// <summary>
    /// Worst case Time complexity: o(n*n), Space complexity: o(1)
    /// Best case time complexity: o(n)
    /// Use case: small array and partially sorted
    /// A stable  & adaptable algorithm
    /// </summary>
    public class InsertionSort
    {
        public void ApplyInsertionSort()
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            int i = 1;
            while (i < arr.Length)
            {
                int previousIndex = i - 1;
                int temp = arr[i];
                while (previousIndex >= 0)
                {
                    if (arr[previousIndex] > temp)
                    {
                        //shift
                        arr[previousIndex + 1] = arr[previousIndex];
                    }
                    else
                    {
                        break;
                    }
                    previousIndex--;
                }

                arr[previousIndex + 1] = temp;
                i++;
            }

            PraintArray(arr);
        }

        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[b];
            arr[b] = arr[a];
            arr[a] = temp;
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
