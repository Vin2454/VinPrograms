using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.BinarySearch
{
    public class FirstAndLastOccurrenceOfElement
    {
        /// <summary>
        /// o(n)
        /// </summary>
        public void FindFirstAndLastOccurrenceOfAnElementWithoutBinarySearch()
        {
            int[] arr = { 0, 0, 1, 1, 2, 2, 2, 2 };
            int key = 2;

            //int[] arr = { 0, 5, 5, 6, 6, 6 };
            //int key = 3;

            int firstOccurrence = -1;
            int lastOccurrence = -1;
            int i = 0;
            while (i < arr.Length)
            {
                if (firstOccurrence == -1 && key == arr[i])
                    firstOccurrence = i;
                if (key == arr[i])
                    lastOccurrence = i;
                i++;
            }
            Console.WriteLine($"First Occurrence: {firstOccurrence}, Last Occurrence: {lastOccurrence}");
        }

        /// <summary>
        /// o(n)
        /// </summary>
        public void FindFirstOccurrenceOfAnElementWithBinarySearch()
        {
            int[] arr = { 0, 0, 1, 1, 2, 2, 2, 2 };
            //int[] arr = { 2, 2, 2 };
            int key = 2;

            int start = 0;
            int end = arr.Length - 1;
            int middle = -1;
            int firstOccurrence = -1;

            while (start <= end)
            {
                middle = start + (end - start) / 2;
                if (key == arr[middle])
                {
                    firstOccurrence = middle;
                    end = middle - 1;
                }
                else if (key < arr[middle])
                    end = middle - 1;
                else
                    start = middle + 1;
            }
            
            Console.WriteLine($"First Occurrence: {firstOccurrence}");
        }

        public void FindLastOccurrenceOfAnElementWithBinarySearch()
        {
            int[] arr = { 0, 0, 1, 1, 2, 2, 2, 2 };
            //int[] arr = { 2, 2, 2 };
            int key = 2;

            int start = 0;
            int end = arr.Length - 1;
            int middle = -1;
            int lastOccurrence = -1;

            while (start <= end)
            {
                middle = start + (end - start) / 2;
                if (key == arr[middle])
                {
                    lastOccurrence = middle;
                    start = middle + 1;
                }
                else if (key < arr[middle])
                    end = middle - 1;
                else
                    start = middle + 1;
            }
            Console.WriteLine($"Last Occurrence: {lastOccurrence}");
        }
    }
}
