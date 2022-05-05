using System;
using System.Collections.Generic;


class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count > 0)
        {
            int max = myList[0];
            foreach (int i in myList)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }
        Console.WriteLine("List is empty");
        return -1;
    }
}

