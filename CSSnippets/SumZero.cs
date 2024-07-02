// function sumZero
// multiple pointer pattern
/*
Write a function called sumZero which accepts a SORTED array of integers. The fubction should find the first pai where the sum is 0. Return an array that includes both values that sum to zero or undefined if a pair does not exist
*/

using System;
using System.Collections.Generic;


namespace CSharpCodeSnippets
{
    public partial class AlgorithmsCSharp
    {
        public static int[] SumZero(int[] inArray)
        {
            int left = 0;           
            int right = inArray.Length - 1;
            Console.WriteLine($"Initial left: {left}");
            Console.WriteLine($"Initial right: {right}");

            int loopCtr = 1;
            
            while(left < right)
            {
                Console.WriteLine($"Loop Ctr: {loopCtr}.");
                Console.WriteLine($"Left index: {left}, Left value: {inArray[left]}.");
                Console.WriteLine($"Right index: {right}, Right value: {inArray[right]}.");
                int sum = inArray[left] + inArray[right];
                Console.WriteLine($"Sum : {sum}.");
                if (sum == 0)
                {
                    return [inArray[left],inArray[right]];
                }
                else
                {
                    if (sum > 0) 
                        {
                         right-- ;
                         Console.WriteLine($"Right-- : {right}.");
                        }
                    else
                        {
                         left++ ;
                         Console.WriteLine($"Left++ : {left}.");
                        }

                }
                loopCtr++;
                Console.WriteLine("");
            }
            return [];
        }
    }
}