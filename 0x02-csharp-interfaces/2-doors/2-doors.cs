using System;


/// <summary> Abstract class Base </summary>
abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {base.GetType()}";
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}


/// <summary> Class Door with inheritance form base and interactive </summary>
class Door : Base, IInteractive
{
    public Door(string itemName = "Door")
    {
        name = itemName;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
