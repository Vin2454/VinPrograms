using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    public class LengthOfLastWordInAString
    {
        public void LengthOfTheLastWordInString()
        {
            // Approach 1: Reverse a string and then find first word from starting
            // Approach 2: Iterate from the end to find the first word from the end
            // Approach 3: Iteratef from the start and find the last word (little complicated when compared with above)

            string input = "Hellow Worlds";
            // Expected: 6

            //string input = "   fly me   to   the moon  "; //here we have 2 empty spaces at the end
            //// Expected: 4

            //string input = " vin";
            //// Expected: 3

            int count = 0;
            int i = 0;

            while (i < input.Length)
            {
                if (input[i] != ' ')
                {
                    count++;
                    i++;
                }
                else
                {
                    while (i < input.Length && input[i] == ' ')//here i<input.Length check needs to be first in the and condition, otherwise index will go out of range
                    {
                        i++;
                    }
                    if (i == input.Length)//here it will be i==input.Length since we have already increment i
                    {
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            Console.WriteLine($"count:{count}");
        }
    }
}
