using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
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
        }
    }
}
