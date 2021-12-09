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
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int middle = start + (end - start) / 2;

                if (key == arr[middle])
                {
                    Console.WriteLine($"key found at {middle}.");
                    return;
                }
                else if (key < arr[middle])
                    end = middle - 1;
                else
                    start = middle + 1;
            }
            Console.WriteLine($"key not found.");
        }

        //public void BitwiseBinarySearch()
        //{
        //    int[] arr = { 1, 3, 5, 7, 8 };
        //    int key = 3;
        //    int size = arr.Length;
        //    int index, power;

        //    //Compute the first power of 2 that is >= size
        //    for (power = 1; power < size; power <<= 1) ;

        //    //loop while(power > 0)
        //    //and divide power by two each iteration
        //    for (index = 0; ; power >>= 1)
        //    {

        //        //if the next condition is true
        //        //it means that the power value can contribute to the "sum"(a closer index where target might be)
        //        if (index + power < size && arr[index + power] <= key)
        //            index += power;
        //    }
        //    //if the element at position [index] == key,
        //    //the key value is present in the array
        //    if (arr[index] == key)
        //        Console.WriteLine($"key found at {index}.");
        //}
    }
}
