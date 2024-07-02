using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace CSharpCodeSnippets
{
    public partial class AlgorithmsCSharp
    {
        public static int CountUniqueValues(int[] inArray)
        {
            int curCtr = 0;
            int nxtCtr = 1;
            //int loopCtr =1;

            while(nxtCtr < inArray.Length)
            {
                if (inArray[curCtr] == inArray[nxtCtr])
                {
                    nxtCtr++; 
                }
                else
                {
                    if (nxtCtr == curCtr + 1)
                    {
                        curCtr++;
                        nxtCtr++;
                    }
                    else
                    {
                        curCtr++;
                        var newElement = inArray[nxtCtr];
                        inArray[curCtr] = newElement;
                        nxtCtr++;
                    }
                }

            }

            return (curCtr == 0) ? 0 : curCtr + 1;
        }       
    }
}