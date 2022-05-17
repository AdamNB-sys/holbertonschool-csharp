using System;

/// <summary> Base class Shape </summary>
class Shape
{
    /// <summary> Public method to set area </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary> Subclass Rectangle with inheritance from Shape </summary>
class Rectangle : Shape
{
    /// Private field width
    private int _width;
    /// Private field height
    private int _height;

    /// <summary> Public getter and setter for width </summary>
    public int Width
    {
        get { return _width; }
        set
        {
            if (value < 0) { throw new ArgumentException("Width must be greater than or equal to 0"); }
            else _width = value;
        }
    }

    /// <summary> Public getter and setter for height </summary>
    public int Height
    {
        get { return _height; }
        set
        {
            if (value < 0) { throw new ArgumentException("Height must be greater than or equal to 0"); }
            else _height = value;
        }
    }

    /// <summary> Public override method to return area of Rectangle </summary>
    public new int Area()
    {
        return _height * _width;
    }

    /// <summary> Public override of the ToString method </summary>
    public override string ToString()
    {
        return $"[Rectangle] {_width} / {_height}";
    }
}

/// <summary> Subclass Square with inheritance from Rectangle </summary>
class Square : Rectangle
{
    /// Private field size
    private int _size;

    /// <summary> Public getter and setter for Square size </summary>
    public int Size
    {
        get { return _size; }
        set
        {
            if (value < 0) { throw new ArgumentException("Size must be greater than or equal to 0"); }
            else 
                _size = value;
                Width = value;
                Height = value;
        }
    }

    /// <summary> Public override of ToString method for Square </summary>
    public override string ToString()
    {
        return $"[Square] {_size} / {_size}";
    }
}
