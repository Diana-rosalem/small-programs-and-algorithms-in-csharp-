using System;

class DNode
{
    public int data;
    public DNode next;
    public DNode ant;

    public DNode()
    {
        data = -1;
        next = null;
        ant = null;
    }
    public DNode(int value)
    {
        data = value;
    }
}
