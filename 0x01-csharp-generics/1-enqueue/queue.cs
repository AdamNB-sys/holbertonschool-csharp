using System;


/// <summary> Generic class Queue </summary>
class Queue<T>
{
    /// <summary> Gets type of object </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> Creates nodes for queue </summary>
    public class Node
    {
        public var value = null;
        public Node next = null;

        public Node(var value)
        {
            this.value = value;
        }
    }
}
