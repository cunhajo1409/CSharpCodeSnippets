using System;
using System.Collections.Generic;

namespace CSharpCodeSnippets
{
    public partial class AlgorithmsCSharp
    {
        public static int[] RandomIntArrayGenerator(int arrLength, int maxInt)
        {   
            Random rnd = new Random();
            List<int> arr = new List<int>();
            for (int i = 0; i < arrLength; i++)
            {
                int randomNumber = rnd.Next(1, maxInt + 1 ); 
                arr.Add(randomNumber);
            }
            return [.. arr];
        }
    }
}