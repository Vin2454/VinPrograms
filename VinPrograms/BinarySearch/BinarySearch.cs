using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.BinarySearch
{
    public class BinarySearch
    {
        public void BinarySearchBasic()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int key = 10;
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (key == arr[middle])
                {
                    Console.WriteLine($"key found at {middle}.");
                    return;
                }
                else if (key < arr[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            Console.WriteLine($"key not found.");
        }
    }
}
