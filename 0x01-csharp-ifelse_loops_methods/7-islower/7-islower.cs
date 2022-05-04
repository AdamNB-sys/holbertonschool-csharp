using System;

class Character
{
    public static bool IsLower(char c)
    {
        if (c < 122 && c > 96)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
