using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class ShiftArrayByNPositions
    {
        /// <summary>
        /// Time complexity: O(n^2), Space complexity: O(n)
        /// </summary>
        public void LeftShiftTheArrayByNPositions_Method1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int leftShiftByPositions = 102;
            int actualLeftShifts = leftShiftByPositions % arr.Length;//102%7=4
            // Expected ans: 5,6,7,1,2,3,4

            int cnt = 1;
            while (cnt <= actualLeftShifts)
            {
                // to shift left by one position
                int temp = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = temp;

                cnt++;
            }

            PrintShiftedArray(arr);
            Console.ReadLine();
        }

        /// <summary>
        /// Time complexity: O(n^2), Space complexity: O(n)
        /// </summary>
        public void RightShiftTheArrayByNPositions_Method1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int rightShiftByPositions = 102;
            int actualRightShifts = rightShiftByPositions % arr.Length;//102%7=4
            // Expected ans: 4,5,6,7,1,2,3

            int cnt = 1;
            while (cnt <= actualRightShifts)
            {
                // to right shift by one position
                int temp = arr[arr.Length-1];
                for (int i = arr.Length-1; i >=1; i--)
                {
                    arr[i] = arr[i-1];
                }
                arr[0] = temp;

                cnt++;
            }

            PrintShiftedArray(arr);
            Console.ReadLine();
        }

        /// <summary>
        /// Time complexity: O(n^2), Space complexity is high here: O(n)
        /// </summary>
        public void LeftShiftTheArrayByNPositions_Method2()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int leftShiftByPositions = 102;
            int actualLeftShifts = leftShiftByPositions % arr.Length;//102%7=4
            // Expected ans: 5,6,7,1,2,3,4

            // take to be shifted elements into temp array
            int[] tempArr = new int[actualLeftShifts];
            for (int i = 0; i < actualLeftShifts; i++)
            {
                tempArr[i] = arr[i];
            }

            // place remaning elements to the start of array
            for (int i = 0; i < arr.Length - actualLeftShifts; i++)
            {
                arr[i] = arr[actualLeftShifts + i];
            }

            // place shifted temp array elements into original array
            for (int i = 0; i < tempArr.Length; i++)
            {
                arr[arr.Length + i - actualLeftShifts] = tempArr[i];
            }

            PrintShiftedArray(arr);
            Console.ReadLine();
        }

        /// <summary>
        /// Time complexity: O(n), Space complexity: O(n)
        /// </summary>
        public void LeftShiftTheArrayByNPositions_Method3()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int leftShiftByPositions = 102;
            int actualLeftShifts = leftShiftByPositions % arr.Length;//102%7=4
            // Expected ans: 5,6,7,1,2,3,4

            int[] leftArr = new int[actualLeftShifts];
            int[] rightArr = new int[arr.Length - actualLeftShifts];
            for (int i = 0; i < arr.Length; i++)
            {
                if(i<actualLeftShifts)
                {
                    leftArr[i] = arr[i];
                }
                else if (i >= actualLeftShifts)
                {
                    rightArr[i- actualLeftShifts] = arr[i];
                }
            }
            //reverse left array
            ReverseArray(leftArr);

            //revers right array
            ReverseArray(rightArr);

            // combine left and right array into original array
            for(int i=0;i<arr.Length;i++)
            {
                if (i < actualLeftShifts)
                {
                    arr[i] = leftArr[i];
                }
                else if (i >= actualLeftShifts)
                {
                    arr[i] = rightArr[i - actualLeftShifts];
                }
            }

            // reverse original array
            ReverseArray(arr);

            // print final array
            PrintShiftedArray(arr);
            Console.ReadLine();
        }

        private void ReverseArray(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;

            while (i<=j)
            {
                Swap(arr, i, j);

                i++;
                j--;
            }
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        private void PrintShiftedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
