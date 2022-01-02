using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Stacks
{
    public class NearestSmallerElementOnTheLeftInArray
    {
        public void PrintNextSmallerElementOnTheLeftInArray_BetterSolution()
        {
            //int[] arr = { 3, 2, 1, 4, 5 };
            // expect: -1,-1,-1,1,4

            int[] arr = { 11, 13, 21, 3 };
            // expect: -1,11,13,-1

            //int[] arr = { 1, 3, 2, 4 };
            // expect: -1,1,1,2

            int n = arr.Length;

            Stack<int> s = new Stack<int>();

            int[] arr1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (s.Count == 0)
                    arr1[i] = -1;

                else if (s.Count != 0 && arr[i] > s.Peek())
                    arr1[i] = s.Peek();

                else if (s.Count != 0 && arr[i] <= s.Peek())
                {
                    while (s.Count != 0 && arr[i] <= s.Peek())
                        s.Pop();

                    if (s.Count == 0)
                    {
                        arr1[i] = -1;
                    }
                    else
                    {
                        arr1[i] = s.Peek();
                    }
                }

                s.Push(arr[i]);
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i] + " ---> " +
                                  arr1[i]);
        }
    }
}
