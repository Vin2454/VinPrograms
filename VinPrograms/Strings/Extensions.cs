using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class Extensions
    {
        public void PrintAsciiCode()
        {
            string input = "stephen";
            char[] cArr = input.ToCharArray();
            foreach (var item in cArr)
            {
                //Console.WriteLine(item); //prints actual char
                Console.WriteLine((int)item); //prints ascii value
            }
        }
        public void PrintAllOccurrencesOfAGivenString()
        {
            string input = "I liked the movie, acting in movie was great!";
            string searchWord = "movie";
            // expected to print: 12, 29

            // Here Split(' ') or split with space won't work since 'movie,' has comma
            // So need to use indexOf

            List<int> occurrences = new List<int>();
            int i = 0;
            while (true)
            {
                i = input.IndexOf(searchWord, i); //string value, int startIndex
                if (i == -1)
                    break;
                occurrences.Add(i);
                i = i + searchWord.Length;
            }

            foreach (int occurenceIndex in occurrences)
            {
                Console.WriteLine(occurenceIndex);
            }
        }

        ///Here is the use of in-place swap without any temp variable  
        public static string ReverseString3(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }
    }
}
