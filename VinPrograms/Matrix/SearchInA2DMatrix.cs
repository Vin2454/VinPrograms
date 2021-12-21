using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Matrix
{
    public class SearchInA2DMatrix
    {
        /// <summary>
        /// Time complexity: O(log(rows*columns)) 
        /// https://leetcode.com/problems/search-a-2d-matrix/
        /// </summary>
        public void SearchIn2DMatrixWithBinarySearch()
        {
            //Constraints
            //Integers in each row are sorted from left to right.
            //The first integer of each row is greater than the last integer of the previous row.
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

            while (start <= end)
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

        /// <summary>
        /// Time complexity: 
        /// https://leetcode.com/problems/search-a-2d-matrix-ii/
        /// </summary>
        public void SearchIn2DMatrixByReducingSearchSpace()
        {
            //Constraints
            //Integers in each row are sorted in ascending from left to right.
            //Integers in each column are sorted in ascending from top to bottom
            int[][] arr =
            {
                new int[]{1,4,7,11,15 },
                new int[]{2,5,8,12,19 },
                new int[]{ 3, 6, 9, 16, 22 },
                new int[]{ 10, 13, 14, 17, 24 },
                new int[]{ 18, 21, 23, 26, 30 }
            };
            int key = 5;
            // answer should be True

            int rows = arr.Length;
            int columns = arr[0].Length;

            //start search from top right corner which reduces search spaces for the given constraints
            int rowIndex = 0; //first row
            int columnIndex = columns - 1; //last column

            while (rowIndex<rows &&columnIndex>=0)
            {
                int element = arr[rowIndex][columnIndex];
                if (key == element)
                {
                    Console.WriteLine($"key found.");
                    return;
                }
                else if (key > element)
                    rowIndex++;
                else if (key < element)
                    columnIndex--;
            }
            Console.WriteLine($"key not found.");
        }
    }
}
