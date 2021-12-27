using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Stacks
{
    public class NextGreaterElementOnTheRightInArray
    {
        /// <summary>
        /// Time Complexity: O(n), using Stack
        /// We push elements to stack for which we will try to find next greater element
        /// https://www.geeksforgeeks.org/next-greater-element/
        /// </summary>
        public void PrintNextGreaterElementOnTheRightInArray_Solution1()
        {
            int[] arr = { 3, 2, 1, 4, 5 }; // good example to understand

            //int[] arr = { 11, 13, 21, 3 };

            int n = arr.Length;

            int i = 0;
            stack s = new stack();
            s.top = -1;
            int element, current;

            /* push the first element to stack */
            s.push(arr[0]);

            // iterate for rest of the elements
            for (i = 1; i < n; i++)
            {
                current = arr[i];

                if (s.Empty == false)
                {

                    // if stack is not empty, then
                    // pop an element from stack
                    element = s.pop();

                    /* If next is less than element, then push the element back */
                    if (current < element)
                    {
                        s.push(element);
                    }

                    /* If next is greater than the popped element, 
                       then a) print the pair b) keep popping while elements are smaller and
                       stack is not empty */
                    while (current > element)
                    {
                        Console.WriteLine(element + " --> " + current);
                        if (s.Empty == true)
                        {
                            break;
                        }
                        element = s.pop();
                    }
                }

                /* push next to stack so that we can find next
                   greater for it */
                s.push(current);
            }

            /* After iterating over the loop, the remaining
               elements in stack do not have the next greater
               element, so print -1 for them */
            while (s.Empty == false)
            {
                element = s.pop();
                current = -1;
                Console.WriteLine(element + " -- " + current);
            }
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/next-greater-element-in-same-order-as-input/
        /// Start from the right side, push element into stack and see if it is greater than previous element
        /// Idea is to keep greater elements in the Stack (greatest being on the top)
        /// </summary>
        public void PrintNextGreaterElementOnTheRightInArray_BetterSolution()
        {
            //int[] arr = { 3, 2, 1, 4, 5 }; // good example to understand

            int[] arr = { 11, 13, 21, 3 };

            int n = arr.Length;

            Stack<int> s = new Stack<int>();

            int[] arr1 = new int[n];

            // iterating from n-1 to 0
            for (int i = n - 1; i >= 0; i--)
            {
                // It's important to have this condition before next conditions, otherwise, will get incorrect answer
                /*Remove unnecessary elements first.We will pop till we get the
              greater element on top or stack gets empty*/
                while (s.Count != 0 && s.Peek() <= arr[i])
                    s.Pop(); // these are of no use

                /*if stack gets empty means there
               is no element on right which is greater
               than the current element.
               if not empty then the next greater
               element is on top of stack*/
                if (s.Count == 0)
                    arr1[i] = -1;
                //Console.WriteLine(arr[i] + " ---> " + "-1");

                if(s.Count != 0 && s.Peek() > arr[i])
                    //Console.WriteLine(arr[i] + " ---> " + s.Peek());
                    arr1[i] = s.Peek();

                s.Push(arr[i]);
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i] + " ---> " +
                                  arr1[i]);
        }
    }
   public class stack
    {
        public int top;
        public int[] items = new int[100];

        public virtual void push(int x)
        {
            if (top == 99)
            {
                Console.WriteLine("Stack full");
            }
            else
            {
                items[++top] = x;
            }
        }

        public virtual int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Underflow error");
                return -1;
            }
            else
            {
                int element = items[top];
                top--;
                return element;
            }
        }

        public virtual bool Empty
        {
            get { return (top == -1) ? true : false; }
        }
    }
}
