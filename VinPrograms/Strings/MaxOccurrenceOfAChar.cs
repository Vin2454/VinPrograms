using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class MaxOccurrenceOfAChar
    {
        static int ASCII_SIZE = 256;

        /// <summary>
        /// Time complexity: O(n), Space comlexity: O(1)
        /// </summary>
        public void MaximumOccurrenceOfACharacter()
        {

            string input = "sample string";

            // Create array to keep the count of
            // individual characters and
            // initialize the array as 0
            int[] count = new int[ASCII_SIZE];

            // Construct character count array
            // from the input string.
            int len = input.Length;
            for (int i = 0; i < len; i++)
                count[input[i]]++;

            int max = -1; // Initialize max count
            char result = ' '; // Initialize result

            // Traversing through the string and
            // maintaining the count of each character
            for (int i = 0; i < len; i++)
            {
                if (max < count[input[i]])
                {
                    max = count[input[i]];
                    result = input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
