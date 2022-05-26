using System;


/// <summary> Class Player with implementation of name, maxHp, and hp </summary>
class Player
{
    private string name;
    private float maxHp;
    public float hp;

    /// <summary> Class constructor Player that instantiates a new instance of Player with parameters </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    /// <summary> Method PrintHealth returns the current health points and name of the Player instance </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}

