using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 99)
            {
                Console.Write(i + " = 0x" + i.ToString("x") + "\n");
                i++;
            }
        }
    }
}
