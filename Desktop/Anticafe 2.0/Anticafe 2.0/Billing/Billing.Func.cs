using System;

namespace Anticafe_2._0
{
    partial class Billing
    {
        public void SetLogIn(String Name, String Tax, Boolean Flayer, DateTime LogIn)
        {
            this.Name = Name;
            this.Tax = Tax;
            this.Flayer = Flayer;
            this.LogIn = LogIn;
        }

        public void SetLogOut(DateTime LogOut)
        {
            this.LogOut = LogOut;

            if ((bill[IdRow].Tax == "Меропр,студудент.")
                || (bill[IdRow].Tax == "Меропр,обычный."))
            {
                totalTime();
                Event.totalTimeEvent();
                Event.CalcEvent();
            }
            else
            {
                totalTime();
                TimeIsMoney();
            }
        }

        public Int32 TimeIsMoney()
        {
            if (LogIn.DayOfYear == LogIn.DayOfYear)
            {
                if ((LogIn.TimeOfDay.TotalMinutes > 960) && (LogOut.TimeOfDay.TotalMinutes < 1321)) //1321 - 22:01
                    Money = (int)Tariff();

                if ((LogIn.TimeOfDay.TotalMinutes > 960) && (LogOut.TimeOfDay.TotalMinutes > 1320)) //1440 - 00:01
                    Money = (int) (Tariff(1320) + (1440 - LogOut.TimeOfDay.TotalMinutes) * 2);

                if ((LogIn.TimeOfDay.TotalMinutes > 1321) && (LogOut.TimeOfDay.TotalMinutes < 1441))
                   Money = (int) ((1440 - LogOut.TimeOfDay.TotalMinutes) * 2);

                if (LogIn.TimeOfDay.TotalMinutes < 960)
                    Money = (int) TotalTime * 2;
            }

            else
            {
                if (LogIn.TimeOfDay.TotalMinutes < 1321)
                    Money = (int)(Tariff(1320) + 240 + TotalTime * 2);

                if (LogIn.TimeOfDay.TotalMinutes > 1320)
                    Money = (int) ((1440 - LogIn.TimeOfDay.TotalMinutes) * 2 + TotalTime * 2);

            }

            return Money;
        }

        protected void  totalTime()
        {
            if (LogIn.DayOfYear == LogIn.DayOfYear)
                TotalTime = (Int32)LogOut.Subtract(LogIn).TotalMinutes;

            else
                TotalTime = (Int32)((1440 - LogIn.TimeOfDay.TotalMinutes) 
                            + LogOut.TimeOfDay.TotalMinutes);
        }

        public Int32 totalTime(DateTime Event)
        {
            if (LogIn.DayOfYear == LogIn.DayOfYear)
                return (Int32)LogOut.Subtract(Event).TotalMinutes;

            else
                return (Int32)((1440 - Event.TimeOfDay.TotalMinutes)
                            + LogOut.TimeOfDay.TotalMinutes);

        }

        private double Tariff() 
        {
            Double Money;
                switch (Tax)
                {
                    case "Обычный":

                        Money = TotalTime * 2;

                        if (Money < 90)
                            Money = 90;

                        if (Flayer)
                            Money = Money - 120;

                        if (Money < 0)
                            Money = 0;
                        break;

                    case "Студенческий":

                        if (TotalTime < 61)
                            Money = TotalTime * 2;

                        if ((TotalTime < 121) && (TotalTime > 60))
                            Money = 120 + (TotalTime - 60) * 1.5;
                        else
                            Money = 210 + (TotalTime - 120);

                        if (Money < 90)
                            Money = 90;

                        if (Flayer)
                            Money = Money - 120;

                        if (Money < 0)
                            Money = 0;

                        break;

                    case "Детский":
                        if (TotalTime < 61)
                            Money = TotalTime * 1.5;
                        else
                            Money = 90 + (TotalTime - 60);

                        if (Money < 90)
                            Money = 90;

                        if (Flayer)
                            Money = Money - 90;

                        if (Money < 0)
                            Money = 0;
                        break;

                    default:
                        Money = 0;
                        break;
                }
            return Money;
        }

        private double Tariff(int TO)
        {
            Double Money;
            Double TT;
            TT = TO - LogIn.TimeOfDay.TotalMinutes;
            switch (Tax)
            {
                case "Обычный":

                    Money = TT * 2;

                    if (Money < 90)
                        Money = 90;

                    if (Flayer)
                        Money = Money - 120;

                    if (Money < 0)
                        Money = 0;
                    break;

                case "Студенческий":

                    if (TT < 61)
                        Money = TT * 2;

                    if ((TT < 121) && (TT > 60))
                        Money = 120 + (TT - 60) * 1.5;
                    else
                        Money = 210 + (TT - 120);

                    if (Money < 90)
                        Money = 90;

                    if (Flayer)
                        Money = Money - 120;

                    if (Money < 0)
                        Money = 0;

                    break;

                case "Детский":
                    if (TT < 61)
                        Money = TT * 1.5;
                    else
                        Money = 90 + (TT - 60);

                    if (Money < 90)
                        Money = 90;

                    if (Flayer)
                        Money = Money - 90;

                    if (Money < 0)
                        Money = 0;
                    break;

                default:
                    Money = 0;
                    break;
            }
            return Money;
        }
    }
}
