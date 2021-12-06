﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class Extensions
    {
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
                i = input.IndexOf(searchWord, i);
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
    }
}
