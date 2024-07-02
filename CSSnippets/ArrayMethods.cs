using System;
using System.Collections.Generic;


namespace CSharpCodeSnippets
{    public partial class AlgorithmsCSharp
    {
        public static void ArraySwap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        
        public static void ArrayPrint(int[] arr, char sep)
        {
            Console.WriteLine($"[{string.Join(sep,arr)}]");
        }

    }
}