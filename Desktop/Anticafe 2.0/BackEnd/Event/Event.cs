using System;
using System.Collections.Generic;

namespace BackEnd
{
    public partial class Event
    {
        public static Int32 colMer;
        public static EventList EList = 0;

        public static DateTime StartEvent1;
        public static DateTime StartEvent2;
        public static Int32 TotalTimeEvent;

        public static Int32 EventValue;
        public static Int32 MafiaValue;

        public enum EventList
        {
            None = 0,
            Mafia = 1,
            Event = 2,
            CinemaNight = 4
        }
    }
}
