// function LongestUniqueString
// Uses sliding window pattern

/*
    A function to return the longest set of characters within a strin gthat contains no duplicate characters
*/


using System;
using System.Collections.Generic;


namespace CSharpCodeSnippets
{
    public partial class AlgorithmsCSharp
    {
        public static string? LongestUniqueString(string inStr)
        {
            if (string.IsNullOrEmpty(inStr))
            {
                return null;
            };

            if (inStr.Length < 2)
            {
                return new string($"Input string = {inStr} \n Longest unique string = {inStr} \n Longest unique string length = {inStr.Length}.");
            }

            char[] charArr = inStr.ToCharArray();
            int loopCtr = 1;
            int max = 0;
            string maxStr = "";

            int curCount = 1;
            int curStart = 0;
            
            Console.WriteLine($"Max string length = {charArr.Length}\n");
            while ((curStart + curCount) <= charArr.Length - 1) 
            {
                char[] tstArr = inStr.Substring(curStart,curCount).ToCharArray();
                Console.WriteLine($"\nLoop = {loopCtr}, tstArr = {new string(tstArr)}, curStart = {curStart}, curCount = {curCount}");
                Console.WriteLine($"Checking {new string(tstArr)} for {charArr[curStart + curCount]}");
                if(tstArr.Contains(charArr[curStart + curCount]))
                {
                    Console.WriteLine($"Duplicate Found, reseetting test string parameters.\n");
                    if (tstArr.Length > max)
                    {
                        maxStr = new string(tstArr);
                        max = tstArr.Length;
                    }

                    curStart = curStart + curCount;
                    curCount = 1;
                }
                else
                {
                    Console.WriteLine("No duplicate, expanding test string by one character.\n");
                    curCount++;
                }
                loopCtr++;
            }
            return 
            new string($"Original String : {inStr}\n Longest unique string : {maxStr}\n Longest unique string length : {max}.");

        }
    
    }
}