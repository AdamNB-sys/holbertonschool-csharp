using System;
using System.Collections.Generic;


class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string>  ascDict = new SortedList<string, string>();
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            // multiDict[pair.Key] = pair.Value * 2;
            ascDict[pair.Key] = pair.Value;
        }
        foreach (KeyValuePair<string, string> pair in ascDict)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
