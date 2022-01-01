using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Matrix
{
    public class ReverseEachRowIn2DMatrix
    {
        public void ReverseEachRowInA2DMatrix()
        {
            int[][] input = {
                new int[]{ 1, 2, 3},
                new int[]{4,5,6 },
                new int[]{7,8,9 },
                new int[]{ 10,11,12}
            };

            //int[][] input = {
            //    new int[]{ 1, 2, 3,4},
            //    new int[]{5,6,7,8 },
            //    new int[]{9,10,11,12 }
            //};

            int rows = input.Length;
            int columns = input[0].Length;

            int currentRow = 0;
            while (currentRow < rows)
            {
                int start = 0;
                int end = columns - 1;
                while (start < end)
                {
                    // swap the elements
                    int temp = input[currentRow][start];
                    input[currentRow][start] = input[currentRow][end];
                    input[currentRow][end] = temp;

                    start++;
                    end--;
                }
                currentRow++;
            }

            Console.WriteLine("Modified matrix is ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(input[i][j] + " ");

                Console.WriteLine();
            }
        }
    }
}
