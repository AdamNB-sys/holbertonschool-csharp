using System;


/// <summary> Abstract Base class </summary>
public abstract class Base
{
    /// <summary> string name is name of base </summary>
    public string name = "";

    /// <summary> ToString method: name + is a + basedotGetType </summary>
    public override string ToString()
    {
        return name + " is a " + base.GetType();
    }
}
