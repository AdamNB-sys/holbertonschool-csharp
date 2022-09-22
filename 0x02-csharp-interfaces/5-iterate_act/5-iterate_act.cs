using System;
using System.Collections.Generic;
using System.Reflection;


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

/// <summary> Class Door inherits from Base and IInteractive </summary>
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

/// <summary> Class Decoration inherits from Base, IInteractive, and IBreakable </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary> Boolean quest item marker </summary>
    public bool isQuestItem { get; set; }

    /// <summary> Get and set for durability </summary>
    public int durability { get; set; }

    /// <summary> Class constructor for Decoration </summary>
    public Decoration(string Name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        name = Name;
        if (durability <= 0)
            throw new Exception ("Durability must be greater than 0");
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary> Implementation of Interactive, returns information about interaction with object </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else //(isQuestItem == false)
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    /// <summary> Implementation of durability, returns information about durability of object </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}

/// <summary> Class Key inherits from Base and ICollectable </summary>
public class Key : Base, ICollectable
{
    /// <summary> Get and set for boolean isCollected </summary>
    public bool isCollected { get; set; }

    /// <summary> Class constructor for Key </summary>
    public Key(string Name = "Key", bool isCollected = false)
    {
        name = Name;
        this.isCollected = isCollected;
    }

    /// <summary> Implementation of Collect method </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

/// <summary> Class RoomObjects introduces new method IterateAction </summary>
class RoomObjects
{
    /// <summary>
    /// IterateAction takes a list of all objects, iterates through it,
    /// and executes methods depending on the interface that object implements.
    /// </summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base item in roomObjects)
        {
            if (type == typeof(IInteractive) && item is IInteractive)
                ((IInteractive)item).Interact();
            if (type == typeof(IBreakable) && item is IBreakable)
                ((IBreakable)item).Break();
            if (type == typeof(ICollectable) && item is ICollectable)
                ((ICollectable)item).Collect();
        }
    }
}
