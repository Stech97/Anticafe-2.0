using System;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace BackEnd
{
    public partial class Admin : Billing
    {
        public void SetStartPage(String name, String day, String time, Int32 sumIn)
        {
            NameAdmin = name;
            Day = day;
            LogInAdmin = time;
            SumLogIn = sumIn;
        }

        //подсчет денег за смену(z-отчёт)
        public Int32 CalcTotalSum()
        {
            for (int i = 0; i < bill.Count; i++)
                TotalSum += bill[i].Money;
            return TotalSum;
        }

        //подсчет итога
        public Int32 CalcItog()
        {
            Itog = SumLogIn + TotalSum + SumInPrazdnik - Rashod;
            return Itog;
        }

        //преобразование месяца из цифр в символьное представление
        private String DateIsStr(int Mount)
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

        //создание файл для диска
        private void CreatFileDisk()
        {
            String Month;
            String Year = DateTime.Now.Year.ToString();
            Month = DateIsStr(DateTime.Now.Month);
            userName = Environment.UserName;

            pathDisk = "C:\\Users\\" + userName + "\\YandexDisk\\" + "Сметки\\"
                + Year + " год\\" + Month + "\\";

            Directory.CreateDirectory(pathDisk);

            pathDisk = pathDisk + Day + ".xlsx";
        }

        //создания файла для машины
        private void CreatFileMashine()
        {
            String Month;
            String Year = DateTime.Now.Year.ToString();
            Month = DateIsStr(DateTime.Now.Month);

            pathMashine = "C:\\Сметки\\" + Year + " год\\" + Month + "\\";
            Directory.CreateDirectory(pathMashine);

            pathMashine = pathMashine + Day + ".xlsx";
        }

        //работа Excel(создание и заполнение)
        private void WorkExcel()
        {
            //создание Excel
            ExcelApp.SheetsInNewWorkbook = 1;
            ExcelApp.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 20;
            ExcelWBS = ExcelApp.Workbooks;
            ExcelAppWB = ExcelWBS[1];
            ExcelApp.Visible = false;
            ExcelApp.DisplayAlerts = false;

            //заполнение Excel
            ExcelApp.Cells[1, 1] = "На смене был:";
            ExcelApp.Cells[1, 2] = NameAdmin;
            ExcelApp.Cells[1, 4] = "Время начала смены:";
            ExcelApp.Cells[1, 5] = LogInAdmin;

            ExcelApp.Cells[3, 1] = "Имя";
            ExcelApp.Cells[3, 2] = "Тип подсчёта";
            ExcelApp.Cells[3, 3] = "Флаер";
            ExcelApp.Cells[3, 4] = "Время прихода";
            ExcelApp.Cells[3, 5] = "Время ухода";
            ExcelApp.Cells[3, 6] = "Время в минутах";
            ExcelApp.Cells[3, 7] = "Сумма к оплате";

            for (int i = 0; i < bill.Count; i++)
            {
                ExcelApp.Cells[i + 4, 1] = bill[i].Name.ToString();
                ExcelApp.Cells[i + 4, 2] = bill[i].Tax.ToString();
                ExcelApp.Cells[i + 4, 3] = bill[i].Flayer.ToString();
                ExcelApp.Cells[i + 4, 4] = bill[i].LogIn.ToShortTimeString();
                ExcelApp.Cells[i + 4, 5] = bill[i].LogOut.ToShortTimeString();
                ExcelApp.Cells[i + 4, 6] = bill[i].TotalTime.ToString();
                ExcelApp.Cells[i + 4, 7] = bill[i].Money.ToString();
            }

            ExcelApp.Cells[bill.Count + 5, 1] = "Начало дня:";
            ExcelApp.Cells[bill.Count + 5, 2] = SumLogIn;
            ExcelApp.Cells[bill.Count + 6, 1] = "Z-отчёт:";
            ExcelApp.Cells[bill.Count + 6, 2] = TotalSum;
            ExcelApp.Cells[bill.Count + 7, 1] = "Предоплата по ДР";
            ExcelApp.Cells[bill.Count + 7, 2] = SumInPrazdnik;
            ExcelApp.Cells[bill.Count + 8, 1] = "Расход:";
            ExcelApp.Cells[bill.Count + 8, 2] = Rashod;
            ExcelApp.Cells[bill.Count + 9, 1] = "Итог:";
            ExcelApp.Cells[bill.Count + 9, 2] = Itog;

            if (Event.EventCheck)
            {
                ExcelApp.Cells[bill.Count + 10, 1] = "Количество людей на мероприятии:";
                ExcelApp.Cells[bill.Count + 10, 2] = Event.EventValue;
            }
        }

        //сохранение в Excel(в диск, машина и удаление BackUp)
        public void SaveInExcel()
        {
            //сохранение на диск
            try
            {
                CreatFileDisk();
                WorkExcel();
                ExcelAppWB.SaveAs(pathDisk, Excel.XlFileFormat.xlOpenXMLWorkbook, "", "Timesuffers01022017", true, true);
                ExcelApp.Quit();
            }
            catch
            {
                ExcelAppWB.Close(true, pathDisk);
                ExcelApp.Quit();
            }

            //сохранение на компьютере
            try
            {
                CreatFileMashine();
                WorkExcel();
                ExcelAppWB.SaveAs(pathMashine, Excel.XlFileFormat.xlOpenXMLWorkbook, "", "Timesuffers01022017", true, true);
            }
            catch
            {
                ExcelAppWB.Close(true, pathMashine);
                ExcelApp.Quit();
                if (BackUp)
                {
                    DirectoryInfo di = new DirectoryInfo(pathBackUp);
                    FileInfo[] fi = di.GetFiles();
                    //В цикле пробегаемся по всем файлам директории di и удаляем их
                    foreach (FileInfo f in fi)
                    {
                        f.Delete();
                    }
                    Directory.Delete(pathBackUp);
                }
            }
        }

        //создание BackUp после действия с гостем
        public Boolean SaveBackUp()
        {
            String Month;
            String Year = DateTime.Now.Year.ToString();
            Month = DateIsStr(DateTime.Now.Month);
            pathBackUp = "C:\\Сметки\\BackUp\\";

            Directory.CreateDirectory(pathBackUp);
            WorkExcel();

            ExcelAppWB.SaveAs(pathBackUp + Year + "_" + Month + "_" + Day + ".temp", Excel.XlFileFormat.xlOpenXMLWorkbook, "", "");
            ExcelApp.Quit();

            return true;            
        }
    }
}
