using System;


/// <summary> Generic class Queue </summary>
class Queue<T>
{
    /// <summary> Gets type of object </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
