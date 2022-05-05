using System;


class Array
{
    public static int[] CreatePrint(int size)
    {
        // returns new array
        // integers start with 0 and inc by 1 until size is met
        // if size == 0 -> blank line
        // if size < 0 -> "Size cannot be negative" return null
        if (size >= 0)
        {
            int[] ArrCopy = new int[size];
            for (int i = 0; i < ArrCopy.Length; i++)
            {
                ArrCopy[i] = i;
                Console.Write("{0} ", ArrCopy[i]);
            }
            Console.Write("\n");
            return ArrCopy;
        }
        else
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
    }
}
