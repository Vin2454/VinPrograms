using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class ReverseWordsInAString
    {
        public void ReverseWordsUsingStack()
        {
            string input = "the sky is blue";

            var result = string.Empty;
            var myStack = new Stack();
            var strBuilder = new StringBuilder();
            foreach (var t in input)
            {
                if (t.Equals(' '))
                {
                    if (strBuilder.Length != 0)
                    {
                        myStack.Push(strBuilder.ToString());
                        strBuilder = new StringBuilder();
                    }
                    continue;
                }

                strBuilder.Append(t);
            }
            if (strBuilder.Length != 0)
            {
                myStack.Push(strBuilder.ToString());
            }

            while (myStack.Count > 0)
            {
                var str = myStack.Pop();
                if (!string.IsNullOrEmpty(result))
                {
                    result += " ";
                }

                result += str;
            }
            Console.WriteLine(result);
        }

        public void ReverseWordsUsingSplit()
        {
            string input = "the sky is blue";
            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var strBuilder = new StringBuilder();
            for (var i = words.Length - 1; i >= 0; i--)
            {
                strBuilder.Append(words[i]).Append(" ");
            }

            Console.WriteLine(string.IsNullOrEmpty(strBuilder.ToString()) ? "" : strBuilder.ToString().Substring(0, strBuilder.Length - 1)); 
        }

        public void ReverseWords_Inplace_WithoutUsingExtraSpace()
        {
            string input = "the sky is blue";
            char[] s = input.ToCharArray();

            // reverse the whole string
            for (int i = 0, j = s.Length - 1; i <= j; i++, j--)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }

            // reverse each word
            int pre = 0;
            int index = 0;
            while (index < s.Length)
            {
                if (s[index] == ' ')
                {
                    for (int j = pre, k = index - 1; j < k; j++, k--)
                    {
                        var temp = s[j];
                        s[j] = s[k];
                        s[k] = temp;
                    }

                    index++;
                    pre = index;
                }

                index++;
            }

            //reverse last word
            for (int j = pre, k = index - 1; j < k; j++, k--)
            {
                var temp = s[j];
                s[j] = s[k];
                s[k] = temp;
            }

            Console.WriteLine(new string(s));
        }
    }
}
