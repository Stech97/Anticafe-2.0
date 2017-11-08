using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace BackEnd
{
    public partial class Admin
    {
        public static Admin admin = new Admin();

        //информация о смене
        public String NameAdmin;
        public String Day;
        public String LogInAdmin;

        //информация о деньгах
        public Int32 SumLogIn; //в начале дня 
        public Int32 SumInPrazdnik; //получено по предоплате за ДР
        public Int32 TotalSum; //сумма в сметке
        public Int32 Rashod; //расходы из textBox
        public Int32 Itog; //общий итог после всех подсчетов  


        //сохранение в Excel
        private String userName;
        private string pathDisk;
        private string pathMashine;
        private string pathBackUp;

        Excel.Workbooks ExcelWBS;
        Excel.Workbook ExcelAppWB;
        Excel.Application ExcelApp = new Excel.Application();
    }
}
