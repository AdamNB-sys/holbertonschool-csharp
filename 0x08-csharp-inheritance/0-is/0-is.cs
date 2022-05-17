using System;
using System.Collections.Generic;

/// <summary> Type checking class for integers. </summary>
class Obj
{
    /// <summary> Tests if the incoming object is an integer </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        else
            return false;
    }
}
