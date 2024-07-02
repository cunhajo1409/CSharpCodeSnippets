using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace CSharpCodeSnippets
{
    public partial class AlgorithmsCSharp
    {
        public static bool SearchLinear(int[] inArr, int target)
        {
            if (inArr.Contains(target)) return true;
            return false;
        }
    }
}