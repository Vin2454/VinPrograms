using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.BinarySearch
{
    public class Programs
    {
        static void Main(string[] args)
        {
            //BinarySearch bs = new BinarySearch();
            //bs.BinarySearchBasic();

            FirstAndLastOccurrenceOfElement falooe = new FirstAndLastOccurrenceOfElement();
            //falooe.FindFirstAndLastOccurrenceOfAnElementWithoutBinarySearch();
            falooe.FindFirstOccurrenceOfAnElementWithBinarySearch();
            falooe.FindLastOccurrenceOfAnElementWithBinarySearch();
        }
    }
}
