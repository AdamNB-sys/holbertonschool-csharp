using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 0; x < 8; x++)
            {
                for (y = 0; y <= 9; y++)
                {
                    if (x < y)
                    {
                        Console.Write("{0}{1}, ", x, y);
                    }
                }
            }
            Console.WriteLine("89");
        }
    }
}
