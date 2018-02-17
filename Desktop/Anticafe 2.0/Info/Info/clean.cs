using System;
using System.Windows.Forms;
using System.Xml;
namespace Info
{
    public partial class clean : Form
    {
        public clean()
        {
            InitializeComponent();
        }

        //чтение из xml
        private void ReadXML(String Day)
        {
            string filePath = "C:\\Сметки\\Info\\Clean.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            
            //четверг работает(Алилуя!!!!!) пазбираемся с переносом текста

            foreach (XmlNode node in doc.DocumentElement.GetElementsByTagName(Day))
            {
                String task = node.FirstChild.InnerText;
                Boolean check = bool.Parse(node.LastChild.InnerText);
                TASK.Items.Add(task, check);
            }
                
            
            /*
             * 
             * TaskData.ReadXml(filePath);
             * TableTask.AutoGenerateColumns = false;
            TableTask.DataSource = TaskData;
            TableTask.DataMember = Day;
            
            TableTask.Columns["Task"].DataPropertyName = "Задание";
            TableTask.Columns["Task"]
            TableTask.Columns["Check"].DataPropertyName = "Выполние";*/
        }

        private void clean_Load(object sender, EventArgs e)
        {

            switch (DateTime.Now.DayOfWeek.ToString())
            { 
                case "Sunday":
                    DayOfWeek.Text = "Воскресенье";
                    ReadXML("Sunday");
                    break;
                case "Monday":
                    DayOfWeek.Text = "Понедельник";
                    ReadXML("Monday");
                    break;
                case "Tuesday":
                    DayOfWeek.Text = "Вторник";
                    ReadXML("Tuesday");
                    break;
                case "Wednesday":
                    DayOfWeek.Text = "Среда";
                    ReadXML("Wednesday");
                    break;
                case "Thursday":
                    DayOfWeek.Text = "Четверг";
                    ReadXML("Thursday");
                    break;
                case "Friday":
                    DayOfWeek.Text = "Пятница";
                    ReadXML("Friday");
                    break;
                case "Saturday":
                    DayOfWeek.Text = "Суббота";
                    ReadXML("Saturday");
                    break;
            }
        }
    }
}
