﻿using System;
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
            SubsequenceRecursion("main",input,output,result);

            Console.WriteLine("-----------------Output-----------------------------------");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //Sort();
        }

        private void SubsequenceRecursion(string caller, string input,string output,List<string> result)
        {
            Console.WriteLine($"caller:{caller} input:{input} output:{output}");
            if (input.Length == 0)
            {
                Console.WriteLine($"-----Exit-----");

                result.Add(output);
                return;
            }

            // rec case
            char ch = input[0];
            string reducedInput = input.Substring(1);

            // includes
            SubsequenceRecursion("include",reducedInput, output + ch, result);

            // excludes
            SubsequenceRecursion("exclude",reducedInput, output, result);
        }
    }
}
