using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Matrix
{
    public class RotateMatrixBy90DegreesAntiClockWise
    {
        // 1) Transpose matrix 2) Reverse each column
        // This works only for SquareMatrix since the used transpose works only for square matrix
        public void RotateMatrixBy90AntiClockWise()
        {
            //e.g: rotate below
            // 1 2 3
            // 4 5 6
            // 7 8 9

            // to
            // 3 6 9
            // 2 5 8
            // 1 4 7

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

            // reverse each column
            for (int i = 0; i < columns; i++)
            {
                int start = 0;
                int end = rows - 1;
                while (start < end)
                {
                    //swap the elements
                    int temp = input[start][i];
                    input[start][i] = input[end][i];
                    input[end][i] = temp;

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
