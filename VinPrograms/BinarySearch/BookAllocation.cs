using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.BinarySearch
{
    public class BookAllocation
    {
        /// <summary>
        /// Using Search space
        /// In BinarySearch, generally we searched with search Key, here we
        /// we search with assumed key(target). So moving pointers(start/end) will be different
        /// o(n)
        /// **Here basically we use binary search on Maximum number of pages a student can read in each distribution 
        /// (which we assume as a mid(solution) in binary search)**
        /// </summary>
        public void AllocateBooks()
        {
            //Number of pages in books
            int[] arr = { 12, 34, 67, 90 };//books array
            //int[] arr = { 10, 20, 30, 40 };//books array
            int n = arr.Length;
            int m = 2; // No. of students

            int minimumNumberOfPages = FindPages(arr, n, m);

            Console.WriteLine($"Minimum number of pages = {minimumNumberOfPages}");
        }

        private int FindPages(int[] arr,
                             int n, int m)
        {
            long sum = 0;

            // return -1 if no. of books
            // is less than no. of students
            if (n < m)
                return -1;

            // Count total number of pages
            for (int i = 0; i < n; i++)
                sum += arr[i];

            // initialize start as 0 pages
            // and end as total pages
            int start = 0, end = (int)sum;
            int result = int.MaxValue;

            // traverse until start <= end
            while (start < end) //start <= end should also work.
            {
                // check if it is possible to
                // distribute books by using
                // mid as current minimum
                int mid = (start + end) / 2;
                if (isPossibleSolution(arr, n, m, mid))
                {
                    // update result to current distribution
                    // as it's the best we have found till now.
                    result = mid;

                    // as we are finding minimum and
                    // books are sorted so reduce
                    // end = mid -1 that means
                    end = mid - 1;
                }

                else
                    // if not possible means pages
                    // should be increased so update
                    // start = mid + 1
                    start = mid + 1;
            }

            // at-last return
            // minimum no. of pages
            return result;
        }

        private bool isPossibleSolution(int[] arr, int n,
                       int m, int currentAssumedMinimum)
        {
            int studentsRequired = 1;
            int currentSum = 0;

            // iterate over all books
            for (int i = 0; i < n; i++)
            {
                // check if current number of
                // pages are greater than curr_min
                // that means we will get the
                // result after mid no. of pages
                if (arr[i] > currentAssumedMinimum)
                    return false;

                // count how many students
                // are required to distribute
                // curr_min pages
                if (currentSum + arr[i] > currentAssumedMinimum)
                {
                    // increment student count
                    studentsRequired++;

                    // update curr_sum
                    currentSum = arr[i];

                    // if students required becomes
                    // greater than given no. of
                    // students, return false
                    if (studentsRequired > m)
                        return false;
                }

                // else update curr_sum
                else
                    currentSum += arr[i];
            }
            return true;
        }
    }
}
