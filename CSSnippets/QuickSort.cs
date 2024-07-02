using System;
using System.Collections.Generic;


namespace CSharpCodeSnippets
{
    public partial class AlgorithmsCSharp
    {
        public static int pivot(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            int swapIdx = start;

            for (int i = start + 1; i <= end; i++)
            {
                if (arr[i] < pivot)
                {
                    swapIdx++;
                    AlgorithmsCSharp.ArraySwap(arr, swapIdx, i);
                }
            }

            AlgorithmsCSharp.ArraySwap(arr, start, swapIdx);
            return swapIdx;
        }
        
        public static void QuickSort(int[] arr,int left, int right)
        {
        if (left < right)
        {
            int pivotIdx = pivot(arr, left, right);
            QuickSort(arr, left, pivotIdx - 1);
            QuickSort(arr, pivotIdx + 1, right);
        }
        }
    }
}