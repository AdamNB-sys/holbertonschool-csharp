using System;
using System.Collections.Generic;


class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int winner = 0;
        string keyName = "";
        if (myList != null && myList.Count > 0)
        {
            foreach (KeyValuePair<string, int> pair in myList)
            {
                if (winner <= pair.Value)
                {
                    winner = pair.Value;
                    keyName = pair.Key;
                }
            }
            return keyName;
        }
        else
        {
            return "None";
        }
    }
}
