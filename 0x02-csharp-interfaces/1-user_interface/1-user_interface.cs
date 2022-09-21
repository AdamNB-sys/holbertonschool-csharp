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

/// <summary> Interface IInteractive to call interact method </summary>
public interface IInteractive
{
    void Interact();
}

/// <summary> Interface IBreakable to set durability and breakability </summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary> Interface ICollectable determines collectability of object </summary>
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary> Class TestObject inherits from Base and all 3 interfaces </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }
    public string name { get; set; }

    public void Interact()
    {
        return;
    }

    public void Break()
    {
        return;
    }

    public void Collect()
    {
        return;
    }
}
