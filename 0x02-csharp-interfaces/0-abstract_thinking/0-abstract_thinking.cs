using System;


/// <summary> Abstract Base class </summary>
public abstract class Base
{
    public string name = "";

    public override string ToString()
    {
        return name + " is a " + base.GetType();
    }
}
