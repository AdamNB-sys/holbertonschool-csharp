using System;


/// <summary> Class for checking if an object is an instance of a class that inherits from another class </summary>
class Obj
{
    /// <summary> Method returns true if object is instance of inherited class, otherwise returns false </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        else
            return false;
    }
}
