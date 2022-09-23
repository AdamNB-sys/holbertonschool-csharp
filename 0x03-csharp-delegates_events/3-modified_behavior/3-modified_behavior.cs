using System;

/// <summary> Public class Player </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Instantiation of Player
    /// Name is "Player" by default
    /// maxHp is 100f by default
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
    }

    /// <summary> Outputs the current health of the Player object </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary> Delegate for health calculation </summary>
    public delegate float CalculateHealth(float points);

    /// <summary> Method to calculte damage </summary>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{this.name} takes {damage} damage!");
            this.hp -= damage;
        }

        ValidateHP(this.hp);
    }

    /// <summary> Method to calculate health regeneration </summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
            this.hp += heal;
        }

        ValidateHP(this.hp);
    }

    /// <summary> Health Validation method </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }

    /// <summary> Calculate attack modifiers </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float modVal = 0;

        switch (modifier)
        {
            case Modifier.Weak:
                modVal = baseValue * 0.5f;
                break;
            case Modifier.Base:
                modVal = baseValue * 1f;
                break;
            case Modifier.Strong:
                modVal = baseValue * 1.5f;
                break;
        }
        return modVal;
    }
}

/// <summary> Modifier denotes attack strengths </summary>
public enum Modifier
{
    /// <summary> Weak modifier, half strength </summary>
    Weak,

    /// <summary> Base modifier, regular strength </summary>
    Base,

    /// <summary> Strong modifier, +50% strength </summary>
    Strong
}

/// <summary> Deligate to return the adjusted modifier </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
