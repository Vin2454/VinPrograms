using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Stacks
{
    public class PrintStackFromBottomToTop
    {
        /// <summary>
        /// Time Complexity: O(N) Auxiliary Space: O(N) 
        /// Another approach, we can use another stack
        /// </summary>
        public void PrintStackFromBottomToTheTop_UsingRecursion()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            PrintStack_ToPreserveStackAndOrder(s);//expected: 1 2 3 4
            Console.WriteLine();
        }

        private void PrintStack(Stack<int> s)
        {
            if (s.Count == 0)
                return;

            int element = s.Pop();
            PrintStack(s);
            Console.WriteLine(element);
        }

        private void PrintStack_ToPreserveStackAndOrder(Stack<int> s)
        {
            if (s.Count == 0)
                return;

            int element = s.Pop();
            PrintStack_ToPreserveStackAndOrder(s);
            Console.WriteLine(element);

            // Push the same element onto the stack to preserve the order
            s.Push(element);
        }
    }
}
