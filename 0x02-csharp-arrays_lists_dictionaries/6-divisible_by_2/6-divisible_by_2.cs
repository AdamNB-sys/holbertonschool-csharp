using System;
using System.Collections.Generic;


class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> evens = new List<bool>();
        foreach (int i in myList)
        {
            if (i % 2 == 0)
                evens.Add(true);
            else
                evens.Add(false);
        }
        return evens;
    }
}
