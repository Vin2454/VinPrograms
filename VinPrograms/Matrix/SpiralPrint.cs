using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Matrix
{
    public class SpiralPrint
    {
        public void PrintSpiral()
        {
            // e,g, for below input, output should be 1 2 3 6 9 8 7 4 5
            // 1 2 3
            // 4 5 6
            // 7 8 9

            // multi dimensional syntax
            //int[,] arr =
            //{
            //    {1,2,3 },
            //    {4,5,6 },
            //    {7,8,9 }
            //};
            //int rows = arr.GetLength(0);
            //int columns = arr.GetLength(1);

            // jagged array syntax
            int[][] arr =
            {
                new int[]{1,2,3 },
                new int[]{4,5,6 },
                new int[]{7,8,9 }
            };

            //int[][] arr =
            //{
            //    new int[]{1,2,3,4 },
            //    new int[]{5,6,7,8 },
            //    new int[]{9,10,11,12 }
            //};
            //// output: 1 2 3 4 8 12 11 10 9 5 6 7 6

            int rows = arr.Length;
            int columns = arr[0].Length;

            int count = 0;
            int totalCells = rows * columns;

            int startingRow = 0;
            int startingColumn = 0;
            int endingRow = rows - 1;
            int endingColumn = columns - 1;
            List<int> ans = new List<int>();

            while (count < totalCells)
            {
                // print starting row
                for(int index=startingColumn;index<=endingColumn;index++)
                {
                    ans.Add(arr[startingRow][index]);
                }
                startingRow++;

                // print ending column
                for (int index = startingRow; index <= endingRow; index++)
                {
                    ans.Add(arr[index][endingColumn]);
                }
                endingColumn--;

                // print ending row
                for (int index = endingColumn; index >=startingColumn; index--)
                {
                    ans.Add(arr[endingRow][index]);
                }
                endingRow--;

                // print starting column
                for (int index = endingRow; index >=startingRow; index--)
                {
                    ans.Add(arr[index][startingColumn]);
                }
                startingColumn++;

                count++;
            }

            Print(ans);
        }

        private void Print(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
