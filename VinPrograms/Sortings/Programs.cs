using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Sortings
{
    public class Programs
    {
        static void Main(string[] args)
        {
            // Stable: Stable sorting algorithms maintain the relative order of records with equal keys (i.e. values). 
            //That is, a sorting algorithm is stable if whenever there are two records R and S with the same key and 
            //with R appearing before S in the original list,R will appear before S in the sorted list.

            //SelectionSort ss = new SelectionSort();
            //ss.ApplySelectionSort();

            BubbleSort bs = new BubbleSort();
            bs.ApplyBubbleSort();
        }
    }
}
