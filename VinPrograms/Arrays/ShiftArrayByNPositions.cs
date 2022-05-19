using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class ShiftArrayByNPositions
    {
        public void LeftShiftTheArrayByNPositions()
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

        public void RightShiftTheArrayByNPositions()
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

        private void PrintShiftedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
