using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class Subsequence
    {
        public void PrintAndSortSubsequenceWithRecursion()
        {
            string input = "ABC";

            string output = "";
            List<string> result = new List<string>();
            SubsequenceRecursion(input,output,result);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //Sort();
        }

        private void SubsequenceRecursion(string input,string output,List<string> result)
        {
            if (input.Length == 0)
            {
                result.Add(output);
                return;
            }

            // rec case
            char ch = input[0];
            string reducedInput = input.Substring(1);

            // includes
            SubsequenceRecursion(reducedInput, output + ch, result);

            // excludes
            SubsequenceRecursion(reducedInput, output, result);
        }
    }
}
