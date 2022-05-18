using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Recursion
{
    public class FirstAndLastOccurrenceOfCharacter
    {
        public static int first = -1;
        public static int last = -1;
        /// <summary>
        /// https://www.youtube.com/watch?v=u-HgzgYe8KA
        /// </summary>
        public void FirstAndLastOccurrenceOfElement()
        {
            string str = "abcdeffabbba";
            char findChar = 'a';
            PrintFirstAndLastCharRec(str, 0, findChar);
            Console.ReadLine();
        }
        private void PrintFirstAndLastCharRec(string input, int idx, char element)
        {
            if (idx == input.Length)
            {
                Console.WriteLine($"first:{first}");
                Console.WriteLine($"last:{last}");
                return;
            }

            char currentChar = input[idx];
            if (currentChar == element)
            {
                if (first == -1)
                {
                    first = idx;
                    last = idx;// if we dont update last here and if a character occurred only one time, it will show -1 for last which is incorrect
                }
                else
                {
                    last = idx;
                }
            }
            PrintFirstAndLastCharRec(input, idx + 1, element);
        }
    }
}
