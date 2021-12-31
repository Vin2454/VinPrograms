using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Matrix
{
    /// <summary>
    /// https://www.geeksforgeeks.org/program-to-find-transpose-of-a-matrix/
    /// </summary>
    public class TransposeOfMatrix
    {
        public void MatrixTranspose_SquareMatrix_ResultInNewArray()
        {
            int[][] input = {
                new int[]{ 1, 1, 1, 1},
                new int[]{ 2, 2, 2, 2},
                new int[]{ 3, 3, 3, 3},
                new int[]{ 4, 4, 4, 4}
            };

            ////// expected output
            //////{
            //////    { 1, 2, 3, 4},  
            //////    { 1, 2, 3, 4}
            //////    { 1, 2, 3, 4}
            //////    { 1, 2, 3, 4}
            //////}


            int rows = input.Length;
            int columns = input[0].Length;

            //int[][] resultArray = new int[rows][columns];
            // error: A jagged array cannot be created entirely with a single statement. Here defining columns giving error

            // below is the way to define JaggedArray row & column size
            int[][] resultArray = new int[rows][];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = new int[columns];
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultArray[i][j] = input[j][i];
                }
            }

            Console.WriteLine("Modified matrix is ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(resultArray[i][j] + " ");

                Console.WriteLine();
            }
        }

        public void MatrixTranspose_RectangularMatrix_ResultInNewArray()
        {
            //// input array rowSize<columnSize
            //int[][] input = {
            //    new int[]{ 1, 2,3,4},
            //    new int[]{ 5,6,7,8},
            //    new int[]{ 9,10,11,12 }
            //};

            //////expected output
            //////{
            //////    { 1, 5,9},  
            //////    { 2,6,10},
            //////    { 3,7,11},
            //////    {4,8,12}
            //////}

            //// input array rowSize>columnSize
            int[][] input = {
                new int[]{ 1, 2,3},
                new int[]{ 4,5,6},
                new int[]{ 7,8,9 },
                new int[]{ 10,11,12 }
            };

            ////expected output
            ////{
            ////    {1,4,7,10},
            ////    { 2,5,8,11 },
            ////    { 3,6,9,12 }
            ////}

            int rows = input.Length;
            int columns = input[0].Length;

            //int[][] resultArray = new int[columns][rows];
            // error: A jagged array cannot be created entirely with a single statement. Here defining rows giving error

            // below is the way to define JaggedArray row & column size
            int[][] resultArray = new int[columns][]; //here we set row size to columns
            for (int i = 0; i < resultArray.Length; i++) 
            {
                resultArray[i] = new int[rows];// and we column size to rows
            }


            //for (int i = 0; i < columns; i++) // here i iteration till columns 
            //{
            //    for (int j = 0; j < rows; j++) // and j iteration till rows
            //    {
            //        resultArray[i][j] = input[j][i];
            //    }
            //}

            // Above(using input array sizes, but columns in 1st iteration, rows in 2nd iteration) or below(using resultArray sizes, and rows in 1st iteration, columns in 2nd iteration) will work

            for (int i = 0; i < resultArray.Length; i++) // here i iteration till columns 
            {
                for (int j = 0; j < resultArray[0].Length; j++) // and j iteration till rows
                {
                    resultArray[i][j] = input[j][i];
                }
            }

            Console.WriteLine("Modified matrix is ");
            for (int i = 0; i < resultArray.Length; i++)
            {
                for (int j = 0; j < resultArray[0].Length; j++)
                    Console.Write(resultArray[i][j] + " ");

                Console.WriteLine();
            }
        }

        /// <summary>
        /// https://www.youtube.com/watch?v=dVH7J8Mqv9A
        /// </summary>
        public void MatrixTranspose_SquareMatrix_Inplace_Method1()
        {
            int[][] input = {
                new int[]{ 1, 1, 1, 1},
                new int[]{ 2, 2, 2, 2},
                new int[]{ 3, 3, 3, 3},
                new int[]{ 4, 4, 4, 4}
            };

            ////// expected output
            //////{
            //////    { 1, 2, 3, 4},  
            //////    { 1, 2, 3, 4}
            //////    { 1, 2, 3, 4}
            //////    { 1, 2, 3, 4}
            //////}


            int rows = input.Length;
            int columns = input[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < columns; j++)
                {
                    if (i < j)
                    {
                        int temp = input[i][j];
                        input[i][j] = input[j][i];
                        input[j][i] = temp;
                    }
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

        /// <summary>
        /// For each i'th iteration, i'th row and i'th column will be fixed
        /// </summary>
        public void MatrixTranspose_SquareMatrix_Inplace_BetterMethod()
        {
            int[][] input = {
                new int[]{ 1, 1, 1, 1},
                new int[]{ 2, 2, 2, 2},
                new int[]{ 3, 3, 3, 3},
                new int[]{ 4, 4, 4, 4}
            };

            ////// expected output
            //////{
            //////    { 1, 2, 3, 4},  
            //////    { 1, 2, 3, 4}
            //////    { 1, 2, 3, 4}
            //////    { 1, 2, 3, 4}
            //////}


            int rows = input.Length;
            int columns = input[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j<columns; j++)
                {
                    int temp = input[i][j];
                    input[i][j] = input[j][i];
                    input[j][i] = temp;
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

        

        /// <summary>
        /// It's Hard. https://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.101.1017&rep=rep1&type=pdf
        /// https://www.geeksforgeeks.org/inplace-m-x-n-size-matrix-transpose/
        /// </summary>
        public void MatrixTranspose_RectangularMatrix_Inplace()
        {
            int[][] input = {
                new int[]{ 1, 2,3,4},
                new int[]{ 5,6,7,8},
                new int[]{ 9,10,11,12 }
            };

            //////expected output
            //////{
            //////    { 1, 5,9},  
            //////    { 2,6,10},
            //////    { 3,7,11},
            //////    {4,8,12}
            //////}

            //int[][] input = {
            //    new int[]{ 1, 2,3},
            //    new int[]{ 4,5,6},
            //    new int[]{ 7,8,9 },
            //    new int[]{ 10,11,12 }
            //};

            ////expected output
            ////{
            ////    {1,4,7,10},
            ////    { 2,5,8,11 },
            ////    { 3,6,9,12 }
            ////}
            
        }
    }
}
