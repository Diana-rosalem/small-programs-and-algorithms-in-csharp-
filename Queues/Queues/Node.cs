using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class Node
    {
        public Person data;
        public Node next;

        public Node(Person data)
        {
            this.data = data;
            next = null;
        }
    }
}
