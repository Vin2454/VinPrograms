using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Arrays
{
    public class RemoveAllAdjacentDuplicatesInAString
    {
        /// <summary>
        /// Time Complexity: O(n), Space Complexity: O(n)
        /// </summary>
        public void RemoveAdjacentDuplicatesInStringUsingStack()
        {
            //string s = "abbaca";//expected output: "ca"
            //string s = "azxxzy";//expected output: "ay"
            string s = "mississippi";//expected output: "m"


            StringBuilder sb = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            stack.Push(s[0]);

            int i = 1;
            while (i < s.Length)
            {
                if (stack.Count > 0 && s[i] == stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }

                i++;
            }

            char[] cArr = new char[stack.Count];
            ReversePrintRec(stack, stack.Count - 1, cArr);
            Console.WriteLine(new String(cArr));
        }
        private void ReversePrintRec(Stack<char> stack, int i, char[] cArr)
        {
            if (stack.Count == 0)
                return;
            else
            {
                char element = stack.Pop();
                ReversePrintRec(stack, i - 1, cArr);
                cArr[i] = element;
            }
        }

        /// <summary>
        /// Time Complexity: O(n), Space Complexity: O(n)
        /// </summary>
        public void RemoveAdjacentDuplicatesInStringUsingHashSet()
        {
            string s = "abbaca";//expected output: "ca"
            //string s = "azxxzy";//expected output: "ay"
            //string s = "mississippi";//expected output: "m"

            HashSet<char> hs = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!hs.Contains(s[i]))
                    hs.Add(s[i]);
                else
                    hs.Remove(s[i]);
            }

            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Time Complexity: O(n), Space Complexity: O(1)
        /// Also called inplace stack
        /// </summary>
        public void RemoveAdjacentDuplicatesInString_WithoutUsing_StackOrHashSet_ItIsInplace()
        {
            //string s = "abbaca";//expected output: "ca"
            //string s = "azxxzy";//expected output: "ay"
            string s = "mississippi";//expected output: "m"
            char[] cArr = s.ToCharArray();

            int stackPointer = -1;
            for (int i = 0; i < cArr.Length; i++)
            {
                char currentChar = cArr[i];
                if (stackPointer == -1 || currentChar != cArr[stackPointer]) //here if you want to avoid the condition stackPointer == -1,
                                                                             //you can start from i=1 and initialize stackPointer to 0
                {
                    stackPointer++;
                    cArr[stackPointer] = cArr[i];
                }
                else
                {
                    stackPointer--;
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <=stackPointer; i++)
            {
                sb.Append(cArr[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
