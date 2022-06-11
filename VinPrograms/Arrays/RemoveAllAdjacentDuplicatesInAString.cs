using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Arrays
{
    public class RemoveAllAdjacentDuplicatesInAString
    {
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
                if (stack.Count > 0 && s[i]==stack.Peek())
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

        public void RemoveAdjacentDuplicatesInStringUsingHashSet()
        {
            string s = "abbaca";//expected output: "ca"
            //string s = "azxxzy";//expected output: "ay"
            //string s = "mississippi";//expected output: "m"

            HashSet<char> hs = new HashSet<char>();
            for(int i=0;i<s.Length;i++)
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
    }
}
