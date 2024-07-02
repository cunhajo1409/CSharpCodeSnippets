// Snippets/StringCharInventory.cs
using System;
using System.Collections.Generic;


namespace CSharpCodeSnippets

{
   public partial class AlgorithmsCSharp 
   {
       public static Dictionary<char, int> StringCharInventory(string inputString) 
       {
           //string inputString = "asdg;lkh;lkh1345h;lksADF;LKJHa;lkdsvZCX77etrpp]w[et[oyiqasfdvjha;df9oo9";
           Dictionary<char, int> charInventory = new Dictionary<char, int>();

           foreach (char x in inputString.ToCharArray())
           {
               bool charIsLower = (int)x >= 97 && (int)x <= 122;
               bool charIsUpper = (int)x >= 65 && (int)x <= 90;
               bool charIsNumber = (int)x >= 48 && (int)x <= 57;
               bool charIsAlpha = charIsUpper || charIsLower;

               if (charInventory.ContainsKey(x))
               {
                   charInventory[x]++;
               }
               else
               {
                   charInventory[x] = 1;
               }
           }

           return charInventory;
       }
   }

}




