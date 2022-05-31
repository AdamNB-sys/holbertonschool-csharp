using System;
using System.Collections.Generic;


/// <summary> Generic class Queue </summary>
class Queue<T>
{
    public Node head = null;
    public Node Tail = null;
    public int count = 0;

    /// <summary> Gets type of object </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> Creates nodes for queue </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T val)
        {
            value = val;
        }
    }

    /// <summary> creates a new node and adds it to the end of the queue </summary>
    public void Enqueue(T val)
    {
        public Node newNode = new Node(T val);
        count += 1;
    }

    /// <summary> Count returns the number of nodes in the queue </summary>
    public void Count()
    {
        return count;
    }
}
