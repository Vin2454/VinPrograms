using System;
using VinPrograms.Arrays;

namespace VinPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //PairSum pws = new PairSum();
            //pws.PrintPairWithSumBruteforce();
            //pws.PrintPairWithSumWithSortingAndBinarySearch();
            //pws.PrintPairWithSumWithoutSortingAndUsingHashSet();

            //TripletSum ts = new TripletSum();
            //ts.PrintTriletSumBruteforce();
            //ts.PrintTriletSumUsingSortingAnd2Pointers();
            //ts.PrintTriletSumUsingHashSet();

            //LongestConsecutiveSequence lcs = new LongestConsecutiveSequence();
            //lcs.LongestConsecutiveSequenceBruteforce();
            //lcs.LongestConsecutiveSequenceWithSorting();
            //lcs.LongestConsecutiveSequenceWithSortingAndUsingHashSet();

            //LongestMountain lm = new LongestMountain();
            //lm.PrintLongestMountainMethod1();
            //lm.PrintLongestMountain2PointerApproach();

            //TrappingRainWater trw = new TrappingRainWater();
            //trw.Trap();

            ShortestUnsortedSubArray susa = new ShortestUnsortedSubArray();
            //susa.FindUnsortedSubarrayBrueforceWithSorting();
            //susa.FindUnsortedSubarrayWithoutSortingIncorrectThoughtProcess();
            susa.FindUnsortedSubarrayWithoutSortingCorrectThoughtProcess();
        }
    }
}
