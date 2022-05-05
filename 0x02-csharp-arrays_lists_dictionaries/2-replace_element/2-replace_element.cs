using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < array.Length && index >= 0)
        {
            array[index] = n;
        }
        else
        {
            Console.WriteLine("Index out of range");
        }
        return array;
    }
}
