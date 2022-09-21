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
public class Door : Base, IInteractive
{
    /// <summary> Class constructor foor Door, sets name to Door </summary>
    public Door(string Name = "Door")
    {
        name = Name;
    }

    /// <summary> Implementation of Interact, returns a message </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
}
