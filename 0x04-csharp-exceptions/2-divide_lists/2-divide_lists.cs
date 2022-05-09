using System;
using System.Linq;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> sumList = new List<int>();
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                int sum = list1[i] / list2[i];
                sumList.Add(sum);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                sumList.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return sumList;
    }
}
