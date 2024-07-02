using System;
using System.Collections.Generic;

namespace CSharpCodeSnippets

{
    public partial class AlgorithmsCSharp
    {
        public static bool AreObjectsEqual(object object1, object object2)
        {

            //refactor this method, maybe using generics, to accept other types
            Dictionary<char,int> obj1 = (Dictionary<char,int>)object1;
            Dictionary<char,int> obj2 = (Dictionary<char,int>)object2;

            // Check if both dictionaries have the same number of elements
            if (obj1.Count != obj2.Count)
            {
                return false;
            }

            // Check if all elements in obj1 exist in obj2 and have the same values
            foreach (var kvp in obj1)
            {
                if (!obj2.ContainsKey(kvp.Key) || obj2[kvp.Key] != kvp.Value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}