using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Matrix
{
    public class SearchInA2DMatrix
    {
        public void SearchIn2DMatrixWithBinarySearch()
        {
            int[][] arr =
            {
                new int[]{1,3,5,7 },
                new int[]{10,11,16,20 },
                new int[]{23,30,34,60 }
            };
            int key = 11;
            // answer should be True

            int rows = arr.Length;
            int columns = arr[0].Length;
            int start = 0;
            int end = rows * columns - 1;

            while (start<=end)
            {
                int middle = start + (end - start) / 2;
                // ***VERY IMPORTANT TO UNDERSTAND****//
                // A row lenght is total number of columns
                // SINCE WE NEED TO FIND MIDDLEELMENT, WE HAVE USED MIDDLE INDEX IN THE NUMERATOR
                int middleElement = arr[middle / columns][middle % columns];

                if (key == middleElement)
                {
                    Console.WriteLine($"key found at {middle}.");
                    return;
                }
                else if (key < middleElement)
                    end = middle - 1;
                else
                    start = middle + 1;
            }
            Console.WriteLine($"key not found.");
        }
    }
}
