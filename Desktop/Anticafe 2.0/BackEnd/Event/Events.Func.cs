using System;

namespace BackEnd
{
    public partial class Event: Billing
    {
        public static void SetStartEvent(String Start)
        {
            DateTime.TryParse(Start, out StartEvent1);
        }

        public static void SetStartEvent(String Start1, String Start2)
        {
            DateTime.TryParse(Start1, out StartEvent1);
            DateTime.TryParse(Start2, out StartEvent2);
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

        public static void CalcMafia()
        {
            switch (bill[IdRow].Tax)
            {
                case "Мафия,обычный":
                    if (TotalTimeEvent < 180)
                        bill[IdRow].Money = 250;

                    if ((TotalTimeEvent > 180) && (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 1441))
                        bill[IdRow].Money = 110 + TotalTimeEvent;

                    if (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 960)
                        bill[IdRow].Money = 410 + (Int32)(bill[IdRow].LogOut.TimeOfDay.TotalMinutes * 2);
                    break;

                case "Мафия,студудент":
                    if (TotalTimeEvent < 180)
                        bill[IdRow].Money = 200;

                    if ((TotalTimeEvent > 180) && (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 1441))
                        bill[IdRow].Money = 70 + TotalTimeEvent;

                    if (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 960)
                        bill[IdRow].Money = 370 + (Int32)(bill[IdRow].LogOut.TimeOfDay.TotalMinutes * 2);
                    break;
            }

        }

        public static void CalcKino()
        {

        }

        //подсчет общего времени на мероприятии
        public static void totalTimeEvent()
        {
            if (bill[IdRow].LogOut.TimeOfDay.TotalMinutes < 1321)
                TotalTimeEvent = (Int32)bill[IdRow].LogOut.Subtract(StartEvent1).TotalMinutes;
            else
                TotalTimeEvent = bill[IdRow].totalTime(StartEvent1);
        }
    }
}
