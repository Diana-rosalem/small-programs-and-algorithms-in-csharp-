using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class Queues
    {
        private Node start;
        private Node end;
        private int _count;
        public Queues()
        {
            start = null;
            end = null;
            _count = 0;
        }
        public void Insert(Person p)
        {
            Node newNode = new Node(p);
            if (IsEmpty())
            {
                start = newNode;
                end = newNode;
            }
            else
            {
                end.next = newNode;
                end = newNode;
            }
            _count++;
        }
        public Person Remove()
        {
            if (IsEmpty())
                return null;

            Person p = start.data;
            if (_count == 1)
            {
                start = null;
                end = null;
            }
            else
            {
                start = start.next;
            }

            _count--;
            return p;
        }
        public bool IsEmpty()
        {
            return start == null;
        }
        public void Clear()
        {
            while (!IsEmpty())
                Remove();
        }
        public int Count()
        {
            return _count;
        }
    }
}
