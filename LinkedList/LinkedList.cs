using System;

class LinkedList
{
    public Node head;
    private int _count;
    public LinkedList()
    {
        head = null;
        _count = 0;
    }

    public void AddFirst(int value)
    {
        Node node = new Node(value);
        node.next = head;
        head = node;
        _count++;
    }

    public void Print()
    {
        Node aux = head;
        while (aux != null)
        {
            Console.Write($"[{aux.data}]->");
            aux = aux.next;
        }
        Console.WriteLine("[null]");
    }

    public Node Find(int Key)
    {
        Node aux = head;
        while(aux !=null && aux.data != Key)
        {
            aux = aux.next;
        }
        return aux;
    }
    public void Remove(int key)
    {   
        //If you have to remove the first
        if(head != null && head.data == key)
        {
            head = head.next;
            _count--;
            return;
        }
        //general case
        Node aux = head;
        while(aux.next != null && aux.next.data != key)
        {
            aux = aux.next;
        }
        //make sure you have found it before removing
        if (aux.next != null)
        {
            aux.next = aux.next.next;
            _count--;
        }
            
    }

    public int Count()
    {
        return _count;
    }

     public void AddOrdered(int value)
    {
        if(head == null || head.data > value)
        {
            AddFirst(value);
        }
        else { 
            Node aux = head;
            while(aux.next != null 
                            && aux.next.data < value)
            {
                aux = aux.next;
            }
            Node newNode = new Node(value);
            newNode.next = aux.next;
            aux.next = newNode;
            _count++;
        }
    }
    public void AddLast(int value)
    {
        if(head == null)
        {
            AddFirst(value);
        }
        else
        {
            Node aux = head;
            while (aux.next != null)
            {
                aux = aux.next;
            }
            Node newNode = new Node(value);
            newNode.next = null;
            aux.next = newNode;
            _count++;
        }
    }

}
