using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anticafe_2._0
{
       public partial class Billing
    {
        public static List<Billing> bill = new List<Billing>();

        //количество гостей
        public static UInt16 LogInValue;
        public static UInt16 LogOutValue;

        //инфо о госте
        public String Name;
        public String Tax;
        public Boolean Flayer;
        public Int32 TotalTime;
        public Int32 Money;

        //вход гостя
        public DateTime LogIn;

        //выход гостя
        public DateTime LogOut;

        public static Int32 IdRow;

        //информация о входе/выходе гостя
        public static Boolean CheckIn;
        public Boolean CheckOut;

        //удаление гостя
        public static Boolean Del;
    }
}
