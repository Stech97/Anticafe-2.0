using System;

namespace BackEnd
{
    public partial class Event: Billing
    {
        public static void SetStartEvent(String Start)
        {
            DateTime.TryParse(Start, out StartEvent);
        }

        //подсчет денег на мероприятии(запуск нужной трификации)
        public static void CalcEvent()
        {
            switch (bill[IdRow].Tax)
            {
                case "Меропр,обычный.":
                    if (TotalTimeEvent < 180)
                        bill[IdRow].Money = 290;

                    if ((TotalTimeEvent > 180) && (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 1441))
                        bill[IdRow].Money = 110 + TotalTimeEvent;

                    if (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 960)
                        bill[IdRow].Money = 410 + (Int32) (bill[IdRow].LogOut.TimeOfDay.TotalMinutes * 2);
                    break;

                case "Меропр,студудент.":
                    if (TotalTimeEvent < 180)
                        bill[IdRow].Money = 250;

                    if ((TotalTimeEvent > 180) && (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 1441))
                        bill[IdRow].Money = 70 + TotalTimeEvent;

                    if (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 960)
                        bill[IdRow].Money = 370 + (Int32)(bill[IdRow].LogOut.TimeOfDay.TotalMinutes * 2);
                    break;
            }

        }

        //подсчет общего времени на мероприятии
        public static void totalTimeEvent()
        {
            if (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 1321)
                TotalTimeEvent = (Int32)bill[IdRow].LogOut.Subtract(StartEvent).TotalMinutes;
            else
                TotalTimeEvent = bill[IdRow].totalTime(StartEvent);
        }
    }
}
