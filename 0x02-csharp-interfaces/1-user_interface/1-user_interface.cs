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
    bool IsCollected { get; set; }
    void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool IsCollected { get; set; }
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
