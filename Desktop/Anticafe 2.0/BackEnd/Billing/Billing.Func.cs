using System;

namespace BackEnd
{
    partial class Billing
    {
        public void SetLogIn(String name, String tax, Boolean flayer, DateTime logIn)
        {
            Name = name;
            Tax = tax;
            Flayer = flayer;
            LogIn = logIn;
        }

        public void SetLogOut(DateTime logOut)
        {
            LogOut = logOut;

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

            if ((bill[IdRow].Tax == "Мафия,обычный")
                || (bill[IdRow].Tax == "Мафия,студудент"))
            {
                totalTime();
                Event.totalTimeEvent();
                Event.CalcMafia();
            }
        }

        //перевод времени в деньги(запуск разных тарифов в зависимости от времени ухода) 
        private Int32 TimeIsMoney()
        {
            if (LogIn.DayOfYear == LogIn.DayOfYear)
            {
                if ((LogIn.TimeOfDay.TotalMinutes > 960) && (LogOut.TimeOfDay.TotalMinutes < 1321)) //1321 - 22:01
                    Money = (int)Tariff();

                if ((LogIn.TimeOfDay.TotalMinutes > 960) && (LogOut.TimeOfDay.TotalMinutes > 1320)) //1440 - 00:00
                {
                    Money = (int) (Tariff(1320));
                    Money =+ (int) ((1440 - LogOut.TimeOfDay.TotalMinutes) * 2);
                }

                if ((LogIn.TimeOfDay.TotalMinutes > 1321) && (LogOut.TimeOfDay.TotalMinutes < 1441))
                   Money = (1440 - (int)LogOut.TimeOfDay.TotalMinutes) * 2;

                if (LogIn.TimeOfDay.TotalMinutes < 960)
                    Money = TotalTime * 2;
            }

            else
            {
                if (LogIn.TimeOfDay.TotalMinutes < 1321)
                    Money = (int)(Tariff(1320) + 240 + (int)(LogOut.TimeOfDay.TotalMinutes * 2));

                if (LogIn.TimeOfDay.TotalMinutes > 1320)
                    Money = ((1440 - (int)LogIn.TimeOfDay.TotalMinutes) * 2) + (int)LogOut.TimeOfDay.TotalMinutes * 2;

            }

            return Money;
        }

        //суммарное время, которое гость провел в Антикафе
        private void  totalTime()
        {
            if (LogIn.DayOfYear == LogIn.DayOfYear)
                TotalTime = (Int32)LogOut.Subtract(LogIn).TotalMinutes;

            else
                TotalTime = (Int32)((1440 - LogIn.TimeOfDay.TotalMinutes) 
                            + LogOut.TimeOfDay.TotalMinutes);
        }

        //суммарное время, которое гость провел в Антикафе на мероприятии
        public Int32 totalTime(DateTime Event)
        {
            if (LogIn.DayOfYear == LogIn.DayOfYear)
                return (Int32)LogOut.Subtract(Event).TotalMinutes;

            else
                return (Int32)((1440 - Event.TimeOfDay.TotalMinutes)
                            + LogOut.TimeOfDay.TotalMinutes);

        }

        //тарифы, если гость ушел до 22:00
        private Double Tariff() 
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

                    Money = 0;
                        
                        if (TotalTime <= 60)
                            Money = TotalTime * 2;

                        if ((TotalTime <= 120) && (TotalTime > 60))
                            Money = 30 + (TotalTime * 1.5);
                         
                        if (TotalTime > 120)
                            Money = 90 + TotalTime;

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
                            Money = 30 + TotalTime;

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

        //Тарифы, если гость пришел до 22:00 и ушел после 22:00
        private Double Tariff(int TO)
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
                    Money = 0;

                    if (TT < 61)
                        Money = TT * 2;

                    if ((TT <= 120) && (TT > 60))
                        Money = 30 + (int)(TT * 1.5);
                    if (TT > 120)
                        Money = 90 + TT;

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
