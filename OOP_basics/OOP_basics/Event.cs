using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_basics
{
    public class Event
    {
        public Event(string name, DecidingEventType eventType, DateTime startDateTime, DateTime endDateTime)
        {
            Name = name;
            EventType = eventType;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }

        public string Name { get; set; }
        
        public enum DecidingEventType
        {
            NoExistingType = 0,
            Coffee = 1,
            Lecture = 2,
            Concert = 3,
            StudySession = 4
        }
        public DecidingEventType EventType { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

    }
}
