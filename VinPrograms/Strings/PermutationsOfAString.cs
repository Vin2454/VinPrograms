using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class PermutationsOfAString
    {
        int level = 0;
        /// <summary>
        /// Can't be done using Binary Tree
        /// Fix position, swap next elements with fix positioned element(From left to right)
        /// Backtracking
        /// Time Complexity: O(n*n!) Note that there are n! permutations and it requires O(n) time to print a permutation.
        /// Another approach is available @https://www.geeksforgeeks.org/c-program-to-print-all-permutations-of-a-given-string-2/
        /// </summary>
        public void PermutationsOfString()
        {
            string input = "ABC";
            Permute(input, 0, input.Length - 1);
        }

        private void Permute(string str, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(str);
            }
            else
            {
                // Since this is not a binary tree, loop is to iterate through edges, for "ABC"
                // first iteration needs to cover 3 edges and 2nd iteration needs to cover 2 edges.
                for (int i = left; i <= right; i++)
                {
                    str = CharSwap(str, left, i);
                    Permute(str, left + 1, right);
                    str = CharSwap(str, left, i);
                }
            }
        }

        public String CharSwap(String input, int i, int j)
        {
            char temp = input[i];
            char[] cArray = input.ToCharArray();

            cArray[i] = cArray[j];
            cArray[j] = temp;

            return new string(cArray);
        }
    }
}
