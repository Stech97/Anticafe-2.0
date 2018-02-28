using System;

namespace BackEnd
{
    public partial class Event
    {
        public static Boolean EventCheck;
        public static Boolean MafiaCheck;

        public static DateTime StartEvent;
        public static Int32 TotalTimeEvent;

        public static Int32 EventValue;
        public static Int32 MafiaValue;

        [Flags]
        public enum EventList
        {
            None = 0,
            Mafia = 1,
            Event = 2,
            CinemaNight = 4
        }
    }
}
