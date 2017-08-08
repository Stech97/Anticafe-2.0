using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace Антикафе_2._0
{
   static class function
    {
        public static String Day;
        public static int StartOfDay;
        public static String WhoOnSmena;
        public static double SumOnSmena;
        public static int VisitorInValue;
        public static int VisitorOutValue;
        public static System.Windows.Forms.DataGridView DGV;
        public static TimeSpan TimeInput;
        public static TimeSpan TimeOutput;
        public static int HourInput;
        public static int HourOutput;
        public static int rashod;
        public static DateTime DayIn;
        public static bool CheckMer;
        public static int MerValue;//количество гостей
        public static DateTime MerStart;
        public static String Time;

        private static String DateIsStr(int Mount)
        {
            switch (Mount)
            {
                case (1):
                    return "Январь";
                case (2):
                    return "Февраль";
                case (3):
                    return "Март";
                case (4):
                    return "Апрель";
                case (5):
                    return "Май";
                case (6):
                    return "Июнь";
                case (7):
                    return "Июль";
                case (8):
                    return "Август";
                case (9):
                    return "Сентябрь";
                case (10):
                    return "Октябрь";
                case (11):
                    return "Ноябрь";
                default:
                    return "Декабрь";
            }

        }

        public static void SaveInExcel()
        {
            //создание файла
            string path;
            String Month;
            String Year = DateTime.Now.Year.ToString();
            Month = DateIsStr(DateTime.Now.Month);
            path = "C:\\" + "Сметки\\" + Year + " год\\" + Month + "\\";
            Directory.CreateDirectory(path);
            path = "C:\\" + "Сметки\\" + Year + " год\\" + Month + "\\" + Day + ".xlsx";

            //объявление excel файла
            Excel.Workbooks ExcelWBS;
            Excel.Workbook ExcelAppWB;
            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.SheetsInNewWorkbook = 1;
            ExcelApp.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 20;
            ExcelWBS = ExcelApp.Workbooks;
            ExcelAppWB = ExcelWBS[1];
            ExcelApp.Visible = false;
            ExcelApp.DisplayAlerts = false;

            //заполнение таблицы
            ExcelApp.Cells[1, 1] = "На смене был:";
            ExcelApp.Cells[1, 2] = WhoOnSmena;
            ExcelApp.Cells[3, 1] = "Имя";
            ExcelApp.Cells[3, 2] = "Тип подсчёта";
            ExcelApp.Cells[3, 3] = "Флаер";
            ExcelApp.Cells[3, 4] = "Время прихода";
            ExcelApp.Cells[3, 5] = "Время ухода";
            ExcelApp.Cells[3, 6] = "Время в минутах";
            ExcelApp.Cells[3, 7] = "Сумма к оплате";

            for (int i = 0; i < DGV.RowCount; i++)
                for (int j = 0; j < DGV.ColumnCount; j++)
                    ExcelApp.Cells[i + 4, j + 1] = DGV[j, i].Value.ToString();

            ExcelApp.Cells[DGV.RowCount + 5, 1] = "Начало дня:";
            ExcelApp.Cells[DGV.RowCount + 5, 2] = StartOfDay;
            ExcelApp.Cells[DGV.RowCount + 6, 1] = "Z-отчёт:";
            ExcelApp.Cells[DGV.RowCount + 6, 2] = SumOnSmena.ToString();
            ExcelApp.Cells[DGV.RowCount + 7, 1] = "Расход:";
            ExcelApp.Cells[DGV.RowCount + 7, 2] = rashod.ToString();
            ExcelApp.Cells[DGV.RowCount + 8, 1] = "Итог:";
            ExcelApp.Cells[DGV.RowCount + 8, 2] = (Convert.ToDouble(StartOfDay) + SumOnSmena - rashod).ToString();
            if (CheckMer)
            {
                ExcelApp.Cells[DGV.RowCount + 9, 1] = "Количество людей на мероприятии:";
                ExcelApp.Cells[DGV.RowCount + 9, 2] = MerValue.ToString();
            }

            // сохранение и закрытие excel-file
            try
            {
                ExcelAppWB.SaveAs(path,
                    Excel.XlFileFormat.xlOpenXMLWorkbook,
                    "", " ");
                ExcelApp.Quit();
            }            
            catch (Exception ex)
            {
                ExcelAppWB.Close(true, @path + Day + ".xlsx");
                ExcelApp.Quit();
                string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
                if (!Directory.Exists(pathToLog))
                    Directory.CreateDirectory(pathToLog); // Создаем директорию, если нужно
                string filename = Path.Combine(pathToLog, string.Format("{0}_{1:dd.MM.yyy}.log",
                AppDomain.CurrentDomain.FriendlyName, DateTime.Now));
                string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n",
                DateTime.Now, ex.TargetSite.DeclaringType, ex.TargetSite.Name, ex.Message);
                File.AppendAllText(filename, fullText, Encoding.GetEncoding("Windows-1251"));
            }
        }
    }
}
