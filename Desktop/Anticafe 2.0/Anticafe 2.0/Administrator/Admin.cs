﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anticafe_2._0
{
    partial class Admin
    {
        public static List<Admin> admin = new List<Admin>();

        //информация о смене
        public String NameAdmin;
        public String Day;
        public String LogInAdmin;

        //информация о деньгах
        public Int32 SumLogIn;//в начале дня
        public Int32 SumInPrazdnik;//получено по предоплате за ДР
        public Int32 TotalSum;//сумма в сметке
        public Int32 Rashod;//расходы из textBox
        public Int32 Itog;// общий итог после всех подсчетов  
          
    }
}