using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Recursion
{
    public class RemoveAllDuplicatesInAString
    {
        public static bool[] map = new bool[26];
        public void RemoveAllDuplicatesInString()
        {
            string input = "abbccda";
            RemoveAllDuplicatesInStringRec(input, 0,string.Empty);
            Console.ReadLine();
        }

        private void RemoveAllDuplicatesInStringRec(string input,int idx,string newString)
        {
            if(idx==input.Length)
            {
                Console.WriteLine(newString);
                return;
            }

            char currentChar = input[idx];
            if (map[currentChar - 'a'] == true) // or if (map[currentChar - 'a'])
            {
                RemoveAllDuplicatesInStringRec(input, idx + 1, newString);
            }
            else
            {
                newString += currentChar;
                map[currentChar - 'a'] = true;
                RemoveAllDuplicatesInStringRec(input, idx + 1, newString);
            }
        }
    }
}
