using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> Class for testing objects </summary>
class Obj
{
    /// <summary> Method prints the names of properties, and object methods </summary>
    public static void Print(object myObj)
    {
        string name = myObj.GetType().Name;

        Console.WriteLine("{0} Properties:", name);
        foreach (var item in myObj.GetType().GetProperties())
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine("{0} Methods", name);
        foreach (var item in myObj.GetType().GetMethods())
        {
            Console.WriteLine(item.Name);
        }
    }
}

