using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VinPrograms.Strings
{
    public class PermutationInAString
    {
        public void PermuationInString()
        {
            //string MainString = "eidbaooo";
            //string part = "ab"; // permutations of ab are ab & ba. ba exists in MainString

            //// character count array
            //int[] count1 = Enumerable.Repeat(0, 26).ToArray();

            //for (int i = 0; i < part.Length; i++)
            //{
            //    int index = part[i] - 'a';
            //    count1[index]++;
            //}

            //// traverse MainString in window of part length and compare 
            //int j = 0;
            //int windowSize = part.Length;
            //int[] count2 = Enumerable.Repeat(0, 26).ToArray();
            //// running for first window
            //while (j < windowSize && j<MainString.Length)
            //{
            //    int index = MainString[j] - 'a';
            //    count2[index]++;
            //    j++;
            //}
            //if (CheckEqual(count1, count2))
            //{
            //    Console.WriteLine(true);
            //    return;
            //}

            //// next window
            //while (j < MainString.Length)
            //{
            //    char newChar = MainString[j];
            //    int index = newChar - 'a';
            //    count2[index]++;

            //    char oldChar = MainString[j - windowSize];
            //    index = oldChar - 'a';
            //    count2[index]--;
            //}
            //j++;
            //if (CheckEqual(count1, count2))
            //{
            //    Console.WriteLine(true);
            //    return;
            //}
        }

        private bool CheckEqual(int[] count1, int[] count2)
        {
            for (int i = 0; i < 26; i++)
            {
                if (count1[i] != count2[i])
                    return false;
            }
            return true;
        }
    }
}
