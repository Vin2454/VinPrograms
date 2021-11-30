using System;

namespace VinPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestConsecutiveSequence lcs = new LongestConsecutiveSequence();
            //lcs.LongestConsecutiveSequenceBruteforce();
            //lcs.LongestConsecutiveSequenceWithSorting();
            lcs.LongestConsecutiveSequenceWithoutSorting();
        }
    }
}
