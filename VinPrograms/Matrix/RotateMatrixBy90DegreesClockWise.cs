using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Matrix
{
    // check: https://www.youtube.com/watch?v=Y72QeX0Efxw
    public class RotateMatrixBy90DegreesClockWise
    {
        // 1) Transpose matrix 2) Reverse each row
        // This works only for SquareMatrix since the used transpose works only for square matrix
        public void RotateMatrixBy90ClockWise()
        {
            //e.g: rotate below
            // 1 2 3
            // 4 5 6
            // 7 8 9

            // to
            // 7 4 1
            // 8 5 2
            // 9 6 3

            int[][] input =
            {
                new int[]{1,2,3 },
                new int[]{4,5,6 },
                new int[]{7,8,9 }
            };

            int rows = input.Length;
            int columns = input[0].Length;

            // transpose
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < columns; j++)
                {
                    int temp = input[i][j];
                    input[i][j] = input[j][i];
                    input[j][i] = temp;
                }
            }

            // reverse each row
            for (int i = 0; i < rows; i++)
            {
                int start = 0;
                int end = columns - 1;
                while (start < end)
                {
                    //swap the elements
                    int temp = input[i][start];
                    input[i][start] = input[i][end];
                    input[i][end] = temp;

                    start++;
                    end--;
                }
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
