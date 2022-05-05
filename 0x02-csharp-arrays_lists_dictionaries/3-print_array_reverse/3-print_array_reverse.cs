using System;


class Array
{
    public static void Reverse(int[] array)
    {
        if ( array != null && array.Length > 0)
        {
            int i = array.Length - 1;
            while (i > 0)
            {
                Console.Write($"{array[i]} ");
                i--;
            }
            Console.Write(array[0]);
        }
        Console.Write("\n");
    }
}
