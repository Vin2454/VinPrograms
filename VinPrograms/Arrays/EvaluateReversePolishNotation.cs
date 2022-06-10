using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Arrays
{
    /// <summary>
    /// This is also called as a PostFix evaluation
    /// https://leetcode.com/problems/evaluate-reverse-polish-notation/
    /// </summary>
    public class EvaluateReversePolishNotation
    {
        public void EvaluateReversePolishNotationUsingStack()
        {
            string[] tokens = new string[] { "2", "1", "+", "3", "*" }; //expected Output: 9
            //string[] tokens =new string[] {"4","13","5","/","+"}; //expected Output: 6

            if (tokens == null || tokens.Length == 0)
                Console.WriteLine(0);

            Stack<int> nums = new Stack<int>();

            foreach (var token in tokens)
                if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    int n1 = nums.Pop(),
                        n2 = nums.Pop();

                    if (token == "+")
                        nums.Push(n2 + n1);
                    else if (token == "-")
                        nums.Push(n2 - n1);
                    else if (token == "*")
                        nums.Push(n2 * n1);
                    else
                        nums.Push(n2 / n1);
                }
                else
                    nums.Push(Convert.ToInt32(token));

            Console.WriteLine(nums.Peek());
        }
    }
}
