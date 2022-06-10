using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Arrays
{
    public class ValidPalindrome
    {
        public void ValidPalindrome1()
        {
            string input = "A man, a plan, a canal: Panama";
            // expected output: true as amanaplanacanalpanama is a valid palindrome
            Console.WriteLine(IsPalindrome(input));
        }
        public bool IsPalindrome(string s)
        {
            if (s == null || s == string.Empty)
                return false;

            int i = 0,
                j = s.Length - 1;

            s = s.ToLower();

            while (i < j)
            {
                while (i < j && (s[i] < 'a' || s[i] > 'z') && (s[i] < '0' || s[i] > '9'))
                    i++;

                while (i < j && (s[j] < 'a' || s[j] > 'z') && (s[j] < '0' || s[j] > '9'))
                    j--;
                if (s[i] != s[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }

        //https://leetcode.com/problems/valid-palindrome-ii/
        public void ValidPalindrome2_With_Atmost_OneChar_Remove()
        {
            string input = "abca";
            // expected output: true . remove c, aba become palindrome
            Console.WriteLine(validPalindrome2(input));
        }

        bool validPalindrome2(string A)
        {
            int s = 0;
            int e = A.Length - 1;

            while (s <= e)
            {
                if (A[s] != A[e])
                {
                    /// 2 cases
                    /// delete s  check for A[s+1...e]
                    /// delete e check for A[s...e-1]
                    if (check(A, s + 1, e) || check(A, s, e - 1))
                    {
                        return true;
                    }
                    else
                    {
                        /// after deleting 1 char we are unable to obtain a palin
                        return false;
                    }
                }
                s++;
                e--;
            }

            /// string is already palin
            return true;
        }
        bool check(string A, int s, int e)
        {
            while (s <= e)
            {
                if (A[s] != A[e])
                {
                    return false;
                }
                s++;
                e--;
            }
            return true;
        }

    }
}
