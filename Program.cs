using System;
using System.IO;
using CSharpCodeSnippets;


/*
// call CharInventoryArray

Dictionary<char, int> Inventory = new Dictionary<char, int>();

Inventory = StringCharInventory.RunCharInventory("asdg;lkh;lkh1345h;lksADF;LKJHa;lkdsvZCX77etrpp]w[et[oyiqasfdvjha;df9oo9");

foreach (var item in Inventory)
{
    Console.WriteLine($"Character: '{item.Key}', Count: {item.Value}");
}
*/


/*
// call SumZero
int[] inArray = [-4, -3, -2, -1, 0, 1, 2, 3, 10];

foreach(int z in AlgorithmsCSharp.SumZero(inArray))
{
    Console.WriteLine(z);   
};
*/


// call CountUniqueValues
/*
Console.WriteLine(AlgorithmsCSharp.CountUniqueValues([1, 1, 1, 2, 3, 3, 4, 4, 5, 6]));
Console.WriteLine(AlgorithmsCSharp.CountUniqueValues([1, 2]));
Console.WriteLine(AlgorithmsCSharp.CountUniqueValues([1, 2, 3, 4, 7, 12, 13]));
Console.WriteLine(AlgorithmsCSharp.CountUniqueValues([]));
Console.WriteLine(AlgorithmsCSharp.CountUniqueValues([-2, -1, 0, 1]));
*/

//  call LongestUniqueString

/*Console.WriteLine(AlgorithmsCSharp.LongestUniqueString("herewegoagaindammnit!"));*/

//  call LinearSearch
//Console.WriteLine(AlgorithmsCSharp.SearchLinear([1, 5, 7, 9, 23, 76, 84, 67, 93, 102, 45, 71, 3, 234], 18));
//Console.WriteLine(AlgorithmsCSharp.SearchLinear([1, 5, 7, 9, 23, 76, 84, 67, 93, 102, 45, 71, 3, 234], 84));

// call RandomIntArrayGenerator
/* Generates an array with n random integers between 1 and 500 
*/

/*foreach(int i in (AlgorithmsCSharp.RandomIntArrayGenerator(12, 90)))
{
    Console.WriteLine(i);
}*/

//  call SortQuick
//  first call RandomIntArrayGenerator to gnerate and appropriate array of integers

/*
string logDirectoryPath = "log";
string logBaseFileName = "SortQuiclkLog";
string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
string fileName = $"{logBaseFileName}_{timeStamp}.txt";

string filePath = Path.Combine(logDirectoryPath, fileName);

int[] inArray = AlgorithmsCSharp.RandomIntArrayGenerator(30, 99);

string inArrayMessage = $"[{string.Join(",",inArray)}]";

AlgorithmsCSharp.WriteToLogFile(filePath, inArrayMessage, false);
Console.WriteLine(inArrayMessage);

AlgorithmsCSharp.QuickSort(inArray, 0, inArray.Length - 1);

inArrayMessage = $"[{string.Join(",",inArray)}]";

AlgorithmsCSharp.AppendToLogFile(filePath, inArrayMessage, false);
Console.WriteLine(inArrayMessage);
*/

//  call RadixSort and helper methods
//  first call RandomIntArrayGenerator to gnerate and appropriate array of integers

//Console.WriteLine(AlgorithmsCSharp.GetDigit(7323,3));

//Console.WriteLine(AlgorithmsCSharp.digitCount(7323));

//Console.WriteLine(AlgorithmsCSharp.maxDigitCount([23,345,7654,2345,123456]));

int[] inArray = [
  64, 85, 38, 28, 87, 79, 93, 5, 6, 43, 41, 2, 31, 66, 13, 52, 73, 63, 44, 10,
  24, 24, 91, 22, 78, 25, 27, 30, 44,
];
Console.WriteLine ($"Input Arrary = \n");
AlgorithmsCSharp.ArrayPrint(inArray,',');

Console.WriteLine($"Output sorted array = \n");
AlgorithmsCSharp.ArrayPrint(AlgorithmsCSharp.RadixSort(inArray),',');