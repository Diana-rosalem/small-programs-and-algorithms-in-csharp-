using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class Person
    {
        public Person(string name, int passw)
        {
           Name = name;
            Passw = passw;
        }

        public string Name { get; set; }
        public int Passw { get; set; }
    }
}
