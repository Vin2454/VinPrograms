using System;

namespace VinPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            PairWithSum pws = new PairWithSum();
            //pws.PrintPairWithSumBruteforce();
            //pws.PrintPairWithSumWithSortingAndBinarySearch();
            pws.PrintPairWithSumWithoutSortingAndUsingHashSet();

            //LongestConsecutiveSequence lcs = new LongestConsecutiveSequence();
            //lcs.LongestConsecutiveSequenceBruteforce();
            //lcs.LongestConsecutiveSequenceWithSorting();
            //lcs.LongestConsecutiveSequenceWithSortingAndUsingHashSet();
        }
    }
}
