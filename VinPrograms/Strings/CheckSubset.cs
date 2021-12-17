using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class CheckSubset
    {
        public void IsSubset()
        {
            string s1 = "hello";
            string s2 = "hell";
            //string s1 = "";
            //string s2 = "";
            int i = s1.Length - 1;
            int j = s2.Length - 1;

            while (i >= 0 && j >= 0)
            {
                if (s2[j] == s1[i])
                {
                    i++;
                    j--;
                }
                else
                {
                    i--; // since we need to search s2 in s1
                }
            }
            if (j == -1)
            {
                Console.WriteLine($"{s2} is subset of {s1}");
                return;
            }
            Console.WriteLine($"{s2} is not a subset of {s1}");
        }
    }
}
