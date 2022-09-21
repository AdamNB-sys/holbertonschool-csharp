using System;


/// <summary> Generic class Queue </summary>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count = 0;

    /// <summary> Returns the type of T </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> Public class Node, value is null by default </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;
        public Node (T value)
        {
            this.value = value;
        }
    }

    /// <summary> Enqueue method takes in a value and adds it to the end of the queue </summary>
    public void Enqueue(T value)
    {
        if (head == null)
        {
            this.head = new Node(value);
            this.tail = head;
            this.count++;
        }
        else
        {
            this.tail.next = new Node(value);
            this.tail = this.tail.next;
            this.count++;
        }
    }

    /// <summary> Dequeue removes the head element from the queue </summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T val = head.value;
            head = head.next;
            count--;
            return val;
        }
    }

    ///<summary> Peek method returns the value at the front of the queue </summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T headNode = head.value;
            return headNode;
        }
    }

    /// <summary> Print outputs all elements of the queue to the terminal </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Node iterator = head;
            while (iterator != null)
            {
                Console.WriteLine(iterator.value);
                iterator = iterator.next;
            }
        }
    }

    /// <summary> Concatenate outputs all str or char elements of Queue on one line </summary>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else if (typeof(T) != typeof(Char) && typeof(T) != typeof(String))
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }
        else
        {
            Node iterator = head;
            String cat = "";
            while (iterator != null)
            {
                cat += iterator.value + " ";
                iterator = iterator.next;
            }
            return cat;
        }
    }

    /// <summary> Count method returns the number of elements in the queue </summary>
    public int Count()
    {
        return this.count;
    }
}
