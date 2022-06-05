using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    /// <summary>
    /// https://leetcode.com/problems/longest-happy-string/
    /// </summary>
    public class LongestHappyString
    {
        /// PRIORITY QUEUE UNDERSTAND: https://dotnetcoretutorials.com/2021/03/17/priorityqueue-in-net/
        /// <summary>
        /// task 3: https://leetcode.com/discuss/interview-question/732772/codility-test
        /// </summary>
        public void LongestDiverseString()
        {
            int a = 1, b = 1, c = 7;
            //Output: "ccaccbcc"
            //Explanation: "ccbccacc" would also be a correct answer.

            //1) if absolute difference of m & n is greater than 1, return "IMPOSSIBLE" //Math.Abs(m - n)
            //2) if S and T are equal, return "EQUAL"

            var sb = new StringBuilder();
            var pq = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            if (a != 0) pq.Enqueue('a', a);
            if (b != 0) pq.Enqueue('b', b);
            if (c != 0) pq.Enqueue('c', c);

            while (pq.Count != 0)
            {
                pq.TryDequeue(out var currChar, out var currCount);

                if (sb.Length >= 2 && sb[sb.Length - 1] == sb[sb.Length - 2] && sb[sb.Length - 1] == currChar)
                {
                    if (!pq.TryDequeue(out var nextChar, out var nextCount))
                        break;

                    sb.Append(nextChar);
                    nextCount--;
                    if (nextCount != 0)
                        pq.Enqueue(nextChar, nextCount);
                }
                else
                {
                    currCount--;
                    sb.Append(currChar);
                }

                if (currCount != 0)
                    pq.Enqueue(currChar, currCount);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
