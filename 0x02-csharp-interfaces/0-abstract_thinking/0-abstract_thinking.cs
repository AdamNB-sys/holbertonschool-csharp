using System;


/// <summary> Abstract Base class </summary>
public abstract class Base
{
    /// <summary> string name </summary>
    public string name = "";

    /// <summary> ToString method </summary>
    public override string ToString()
    {
        return name + " is a " + base.GetType();
    }
}
