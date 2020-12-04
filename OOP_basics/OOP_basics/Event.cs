using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_basics
{
    public class Event
    {
        public Event(string name, int eventType, string startTime, string endTime )
        {
            Name = name;
            EventType = eventType;
            StartTime = startTime;
            EndTime = endTime;

        }

        public string Name { get; set; }
        public int EventType { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
