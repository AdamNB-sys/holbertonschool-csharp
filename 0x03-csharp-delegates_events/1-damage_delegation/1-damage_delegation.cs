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

    /// <summary> Delegate CalculateHealth calls methods TakeDamage and HealDamage to calculate Player health </summary>
    public delegate void CalculateHealth(float action);

    /// <summary> TakeDamage calculates Player health after a hit </summary>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{this.name} takes {damage} damage!");
            this.hp = this.hp - damage;
        }
    }

    /// <summary> HealDamage calculates Player health after they heal </summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
            this.hp = this.hp + heal;
        }
    }
}
