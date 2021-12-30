using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Matrix
{
    public class LowerAndUpperMatrixSums
    {
        public void PrintLowerAndUpperMatrixSums()
        {
            int[,] arr =
            {
                {6, 5, 4},
                {1, 2, 5},
                {7, 9, 7}
            };

            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            int lowerSum = 0;
            int upperSum = 0;

            int lr = 0;
            while (lr < rows)
            {
                int lc = 0;
                while (lc < columns)
                {
                    if (lc <= lr)
                        lowerSum += arr[lr, lc];
                    lc++;
                }
                lr++;
            }

            int ur = 0;
            while (ur < rows)
            {
                int uc = 0;
                while (uc < columns)
                {
                    if (ur <= uc)
                        upperSum += arr[ur, uc];
                    uc++;
                }
                ur++;
            }

            Console.WriteLine($"lower triangel sum: {lowerSum} & upper triangle sum: {upperSum}");
        }
    }
}
