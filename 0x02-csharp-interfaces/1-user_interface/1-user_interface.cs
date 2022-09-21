using System;


/// <summary> Abstract Base class </summary>
public abstract class Base
{
    /// <summary> string name is name of base </summary>
    public string name { get; set; }

    /// <summary> ToString method: name + is a + basedotGetType </summary>
    public override string ToString()
    {
        return name + " is a " + base.GetType();
    }
}

/// <summary> Interface IInteractive to call interact method </summary>
public interface IInteractive
{
    /// <summary> Call for Interact method </summary>
    void Interact();
}

/// <summary> Interface IBreakable to set durability and breakability </summary>
public interface IBreakable
{
    /// <summary> Getter and setter for durability </summary>
    int durability { get; set; }

    /// <summary> Call for Break method </summary>
    void Break();
}

/// <summary> Interface ICollectable determines collectability of object </summary>
public interface ICollectable
{
    /// <summary> Getter and setter for boolean isCollected </summary>
    bool isCollected { get; set; }

    /// <summary> Call for Collect method </summary>
    void Collect();
}

/// <summary> Class TestObject inherits from Base and all 3 interfaces </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary> Get and set for durability </summary>
    public int durability { get; set; }

    /// <summary> Get and set for boolean isCollected </summary>
    public bool isCollected { get; set; }

    /// <summary> Interact method, simply returns </summary>
    public void Interact()
    {
        return;
    }

    /// <summary> Break method, only returns </summary>
    public void Break()
    {
        return;
    }

    /// <summary> Collect method, only returns </summary>
    public void Collect()
    {
        return;
    }
}
