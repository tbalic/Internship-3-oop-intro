using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_basics
{
    public class Event
    {
        public Event(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int EventType { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

    }
}
