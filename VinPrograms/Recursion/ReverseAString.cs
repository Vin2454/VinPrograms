using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Recursion
{
    public class ReverseAString
    {
        public void PrintReverseWithRecWithIndex()
        {
            string input = "123456";
            PrintReverseRec(input,input.Length-1);
        }
        public void PrintReverseRec(string str,int idx)
        {
            if(idx==0)
            {
                Console.WriteLine(str[0]); //print first character, means in the loop, it's last from end
                return;
            }
            Console.WriteLine(str[idx]);
            PrintReverseRec(str, idx - 1);
        }
        public void ReverseString()
        {
            string input = "123456";

            // way 1, which is correct
            Console.WriteLine(StringReverse(input));

            //// way 2
            //char[] cArr = input.ToCharArray();
            //ReverseStringRec(ref cArr, 0, input.Length - 1);
            //Console.WriteLine(new string(cArr));

            ////ReverseStringRec(ref input, 0, input.Length - 1);
            ////Console.WriteLine(input);
        }

        public static string StringReverse(string str)
        {
            if (str.Length <= 0)
            {
                return string.Empty;
            }
            else
            {
                char lastChar = str[str.Length - 1];
                string afterExcludingLastChar = str.Substring(0, str.Length - 1);
                string reversed = StringReverse(afterExcludingLastChar);
                return lastChar + reversed;
            }
        }

        public void ReverseStringRec(ref char[] cArr, int start, int end)
        {
            if (start >= end)
                return;

            Swap(ref cArr, start, end);

            ReverseStringRec(ref cArr, start + 1, end - 1);
        }

        private void Swap(ref char[] cArr, int start, int end)
        {
            char temp = cArr[start];
            cArr[start] = cArr[end];
            cArr[end] = temp;
        }

        // below do not work
        //public void ReverseStringRec(ref string input, int start, int end)
        //{
        //    if (start >= end)
        //        return;

        //    //Swap(ref input, start, end);

        //    char[] cArr = input.ToCharArray();
        //    Swap(ref cArr, start, end);

        //    ReverseStringRec(ref input, start + 1, end - 1);
        //}

        //private void Swap(ref string input, int start, int end)
        //{
        //    char temp = input[start];
        //    input[start] = input[end]; //cannot be assinged
        //    input[end] = temp;//cannot be assinged
        //}
    }
}
