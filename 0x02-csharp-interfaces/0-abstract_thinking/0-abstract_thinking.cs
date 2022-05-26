using System;


/// <summary> Abstract class Base </summary>
abstract class Base
{
    public string name;

    public override string ToString()
    {
        return $"{name} is a {base.GetType()}";
    }
}
