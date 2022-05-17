using System;


/// <summary> Type checking class for arrays </summary>
class Obj
{
    /// <summary> Method to check type of incoming object </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj) == true)
            return true;
        else
            return false;
    }
}
