using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace CSharpCodeSnippets;
    public partial class AlgorithmsCSharp
    {
        public static int[] RadixSort(int[] inArray)
        {
        int maxDigiCount = maxDigitCount(inArray);
        for (int k = 0; k < maxDigiCount; k++)
        {
            List<int>[] digitBuckets = new List<int>[10];
            for (int i = 0; i < 10; i++)
            {
                digitBuckets[i] = new List<int>();
            }

            for (int i = 0; i < inArray.Length; i++)
            {
                int thisDigit = GetDigit(inArray[i], k);
                digitBuckets[thisDigit].Add(inArray[i]);
            }

            List<int> mergedList = new List<int>();
            foreach (var bucket in digitBuckets)
            {
                mergedList.AddRange(bucket);
            }

            inArray = mergedList.ToArray();
        }
        return inArray;
        }

        public static int GetDigit(int number, int position)
         /* return a digit at a specific position in a multi digit number by converting
            the number to a string, then converting each char in that string to a single
            digit and adding it an array. Then returnng the requested position from that array
        */
        {           
                    if (position > number.ToString().Length - 1) return 0;

                    string numberStr = number.ToString();       
                    // Convert each character to an integer and then reverse the array
                    int[] digitsArray = numberStr
                        .Select(digit => int.Parse(digit.ToString()))
                        .Reverse()
                        .ToArray();
                    
                    return digitsArray[position];

        }

        public static int digitCount(int number)
        {
            int[] digitArray =  number.ToString()
                     .Select(digit => int.Parse(digit.ToString()))
                     .ToArray();
            return (number == 0) ? 0 : digitArray.Length;
        }

        public static int maxDigitCount(int[] inArray)
        {
            int maxDigits = 0;
            foreach(int i in inArray)
            {
                int count = digitCount(i);
                maxDigits = (count > maxDigits) ? count : maxDigits;
            }

            return maxDigits;
        }
    }
        


