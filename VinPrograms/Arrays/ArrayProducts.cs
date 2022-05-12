using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    /// <summary>
    /// https://www.geeksforgeeks.org/a-product-array-puzzle/
    /// </summary>
    public class ArrayProducts
    {
        public void ProductArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            // Expected output: {120, 60, 40, 30, 24}

            //question: implement a function that takes a vector of integers, and returns a vector of the same lenght,
            //where each element in the output array is equal to the product of every other number in the input array.
            //solve this problem without using division.
            // In other words, the value of output[i] is equal to the product of every number in the input array other than
            //input[i]. You can assume that answer can be stored inside int datatype and no overflow will occur due to products.

            productArray(arr, arr.Length);
            Console.ReadLine();
        }
        static void productArray(int[] arr, int n)
        {

            // Base case
            if (n == 1)
            {
                Console.Write(0);
                return;
            }
            int i, temp = 1;

            /* Allocate memory for the product
            array */
            int[] prod = new int[n];

            /* Initialize the product array as 1 */
            for (int j = 0; j < n; j++)
                prod[j] = 1;

            /* In this loop, temp variable contains
            product of elements on left side
            excluding arr[i] */
            for (i = 0; i < n; i++)
            {
                prod[i] = temp;
                temp *= arr[i];
            }

            /* Initialize temp to 1 for product on
            right side */
            temp = 1;

            /* In this loop, temp variable contains
            product of elements on right side
            excluding arr[i] */
            for (i = n - 1; i >= 0; i--)
            {
                prod[i] *= temp;
                temp *= arr[i];
            }

            /* print the constructed prod array */
            for (i = 0; i < n; i++)
                Console.Write(prod[i] + " ");

            return;
        }
    }
}