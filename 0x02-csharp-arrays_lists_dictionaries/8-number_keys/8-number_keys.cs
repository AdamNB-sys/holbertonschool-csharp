using System;
using System.Collections.Generic;


class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        List<string> keyList = new List<string>();
        foreach (var key in myDict.Keys)
        {
            keyList.Add(key);
        }
        return keyList.Count;
    }
}

