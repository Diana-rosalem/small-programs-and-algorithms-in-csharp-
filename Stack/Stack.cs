using System;


namespace Stack
{
    class Stack
    {
        private Node _top;
        private int _count;
        public Stack()
        {
            _count = 0;
            _top = null;
        }
        //Push: Adds an item in the stack. 
        public void Push(char value)
        {
            Node newNode = new Node(value);
            newNode.next = _top;
            _top = newNode;
            _count++;
        }
        //Pop: Removes an item from the stack. The items are popped in the reversed order in which they are pushed. If the stack is empty, then it is said to be an Underflow condition.
        public char Pop()
        {
            if (IsEmpty())
                throw new Exception("The stack is empty");

            char temp = _top.data;
            _top = _top.next;

            _count--;
            return temp;
        }
        //Count 
        public int Count()
        {
            return _count;
        }

        //isEmpty: Returns true if the stack is empty, else false.
        public bool IsEmpty()
        {
            return _top == null;
        }

        //Clear: destroys the stack, freeing all memory used by the structure.
        public void Clear()
        {
            while (!IsEmpty())
            {
                Pop();
            }
        }
        //Peek or Top: Returns the top element of the stack.
        public char Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("The stack is empty");
            }
            Console.Write($"[{_top.data}]");
            return _top.data;
            
        }
        // Print the Stack
        public void Print()
        {
            Node aux = _top;
            while (aux != null)
            {
                Console.Write($"[{aux.data}]->");
                aux = aux.next;
            }
            Console.WriteLine("[null]");
        }
    }
}
