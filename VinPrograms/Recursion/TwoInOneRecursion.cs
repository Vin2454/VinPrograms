using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Recursion
{
    public class RecursionPractice
    {
        public void HeadTail()
        {
            Console.WriteLine("For number 3 with n-1");
            HeadTailRec(3);
            Console.ReadLine();
        }

        private void HeadTailRec(int n)
        {
            if (n == 0)
            {
                Console.WriteLine(n);
                return;
            }
            Console.WriteLine("tail:" + n);
            TwoInOneRec(n - 1);
            Console.WriteLine("head:" + n);
        }

        public void TwoInOne()
        {
            //TwoInOneRec(3);
            PrintABC("abc");
            Console.ReadLine();
        }

        private void TwoInOneRec(int n)
        {
            if(n==0)
            {
                Console.WriteLine(n);
                return;
            }
            Console.WriteLine("tail:" + n);
            TwoInOneRec(n - 1);
            TwoInOneRec(n - 1);
            Console.WriteLine("head:" +n);
        }

        private void PrintABC(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return;
            }
            Console.WriteLine(input);
            PrintABC(input.Substring(0,input.Length-1));
            PrintABC(input.Substring(0, input.Length - 1));
        }
    }
}
