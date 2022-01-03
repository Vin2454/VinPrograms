using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Stacks
{
    public class BalancedParanthesis
    {
        public void BalancedParanthesisCheck()
        {
            string input = "{(a+b+c)+[d]}";
            Console.WriteLine(IsBalancedParanthesis(input));
        }

        public bool IsBalancedParanthesis(string input)
        {
            int start = 0;
            int end = input.Length;
            Stack<char> paranethesis = new Stack<char>();
            while (start < end)
            {
                char ch = input[start];
                switch (ch)
                {
                    case '{':
                    case '(':
                    case '[':
                        paranethesis.Push(ch);
                        break;

                    case '}':
                        if (paranethesis.Count != 0 && paranethesis.Peek() == '{')
                        {
                            paranethesis.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case ')':
                        if (paranethesis.Count != 0 && paranethesis.Peek() == '(')
                        {
                            paranethesis.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (paranethesis.Count != 0 && paranethesis.Peek() == '[')
                        {
                            paranethesis.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
                start++;
            }

            if (paranethesis.Count == 0)
                return true;

            return false;
        }
    }
}
