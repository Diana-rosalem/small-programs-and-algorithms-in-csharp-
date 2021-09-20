using System;


namespace Stack
{
    class Node
    {
        public char data;
        public Node next;

        public Node(char value)
        {
            data = value;
            next = null;
        }
    }
}
