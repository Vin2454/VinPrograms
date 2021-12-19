using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// NOTE: THIS WILL NOT WORK WITH STRING WITH SPACES AND ONLY WORKS WITH STRING WITH CHARS
        /// </summary>
        public void MaximumOccurrenceOfACharacterDifferentMethod_JustForUnderstanding()
        {
            string input = "samples";
            int[] arr = Enumerable.Repeat(0, 26).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                int number = 0;
                if (ch >= 'a' && ch <= 'z')
                    number = ch - 'a';
                else
                    number = ch - 'A';

                arr[number]++;
            }

            int maxi = -1;
            int ans=-1;

            for (int i = 0; i < 26; i++)
            {
                if(maxi<arr[i])
                {
                    ans = i;
                    maxi = arr[i];
                }
            }

            char finalAnswer = (char)('a' + ans);
            Console.WriteLine(finalAnswer);
        }
    }
}
