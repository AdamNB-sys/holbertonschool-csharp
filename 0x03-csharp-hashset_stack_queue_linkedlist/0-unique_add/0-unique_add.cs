using System;
using System.Collections.Generic;


class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniNumbers = new HashSet<int>();
        foreach (int item in myList)
        {
            uniNumbers.Add(item);
        }
        int total = 0;
        foreach (int item in uniNumbers)
        {
            total += item;
        }
        return total;
    }
}
