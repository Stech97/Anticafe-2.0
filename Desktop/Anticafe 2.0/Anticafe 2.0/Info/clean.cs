using System;
using System.Xml.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Anticafe_2._0
{
    public partial class clean : Form
    {
        public clean()
        {
            InitializeComponent();
        }

        private void clean_Load(object sender, EventArgs e)
        {
            XDocument xml = XDocument.Load
                ("C:\\Сметки\\Info\\Clean++.xml");

            //где есть visible  поменять размер формы
            switch (DateTime.Now.DayOfWeek.ToString())
            { 
                case "Sunday":
                    DayOfWeek.Text = "Воскресенье";
                    Task1.Text = xml.Root.Element("Sunday").Element("t1").Value;
                    Task2.Text = xml.Root.Element("Sunday").Element("t2").Value;
                    Task3.Text = xml.Root.Element("Sunday").Element("t3").Value;
                    Task4.Text = xml.Root.Element("Sunday").Element("t4").Value;
                    Task5.Visible = false;
                    Task6.Visible = false;
                    Task7.Visible = false;
                    Task8.Visible = false;
                    this.Height = 400;
                    break;
                case "Monday":
                    DayOfWeek.Text = "Понедельник";
                    Task1.Text = xml.Root.Element("Monday").Element("t1").Value;
                    Task2.Text = xml.Root.Element("Monday").Element("t2").Value;
                    Task3.Text = xml.Root.Element("Monday").Element("t3").Value;
                    Task4.Text = xml.Root.Element("Monday").Element("t4").Value;
                    Task5.Text = xml.Root.Element("Monday").Element("t5").Value;
                    Task6.Text = xml.Root.Element("Monday").Element("t6").Value;
                    Task7.Text = xml.Root.Element("Monday").Element("t7").Value;
                    Task8.Visible = false;
                    this.Height = 640;
                    break;
                case "Tuesday":
                    DayOfWeek.Text = "Вторник";
                    Task1.Text = xml.Root.Element("Tuesday").Element("t1").Value;
                    Task2.Text = xml.Root.Element("Tuesday").Element("t2").Value;
                    Task3.Text = xml.Root.Element("Tuesday").Element("t3").Value;
                    Task4.Text = xml.Root.Element("Tuesday").Element("t4").Value;
                    Task5.Text = xml.Root.Element("Tuesday").Element("t5").Value;
                    Task6.Text = xml.Root.Element("Tuesday").Element("t6").Value;
                    Task7.Text = xml.Root.Element("Tuesday").Element("t7").Value;
                    Task8.Visible = false;
                    this.Height = 640;
                    break;
                case "Wednesday":
                    DayOfWeek.Text = "Среда";
                    Task1.Text = xml.Root.Element("Wednesday").Element("t1").Value;
                    Task2.Text = xml.Root.Element("Wednesday").Element("t2").Value;
                    Task3.Text = xml.Root.Element("Wednesday").Element("t3").Value;
                    Task4.Text = xml.Root.Element("Wednesday").Element("t4").Value;
                    Task5.Text = xml.Root.Element("Wednesday").Element("t5").Value;
                    Task6.Text = xml.Root.Element("Wednesday").Element("t6").Value;
                    Task7.Text = xml.Root.Element("Wednesday").Element("t7").Value;
                    Task8.Visible = false;
                    this.Height = 640;
                    break;
                case "Thursday":
                    DayOfWeek.Text = "Четверг";
                    Task1.Text = xml.Root.Element("Thursday").Element("t1").Value;
                    Task2.Text = xml.Root.Element("Thursday").Element("t2").Value;
                    Task3.Text = xml.Root.Element("Thursday").Element("t3").Value;
                    Task4.Text = xml.Root.Element("Thursday").Element("t4").Value;
                    Task5.Text = xml.Root.Element("Thursday").Element("t5").Value;
                    Task6.Text = xml.Root.Element("Thursday").Element("t6").Value;
                    Task7.Text = xml.Root.Element("Thursday").Element("t7").Value;
                    Task8.Text = xml.Root.Element("Thursday").Element("t8").Value;
                    break;
                case "Friday":
                    DayOfWeek.Text = "Пятница";
                    Task1.Text = xml.Root.Element("Friday").Element("t1").Value;
                    Task2.Text = xml.Root.Element("Friday").Element("t2").Value;
                    Task3.Text = xml.Root.Element("Friday").Element("t3").Value;
                    Task4.Text = xml.Root.Element("Friday").Element("t4").Value;
                    Task5.Text = xml.Root.Element("Friday").Element("t5").Value;
                    Task6.Text = xml.Root.Element("Friday").Element("t6").Value;
                    Task7.Text = xml.Root.Element("Friday").Element("t7").Value;
                    Task8.Text = xml.Root.Element("Friday").Element("t8").Value;
                    break;
                case "Saturday":
                    DayOfWeek.Text = "Суббота";
                    Task1.Text = xml.Root.Element("Sunday").Element("t1").Value;
                    Task2.Text = xml.Root.Element("Sunday").Element("t2").Value;
                    Task3.Text = xml.Root.Element("Sunday").Element("t3").Value;
                    Task4.Visible = false;
                    Task5.Visible = false;
                    Task6.Visible = false;
                    Task7.Visible = false;
                    Task8.Visible = false;
                    this.Height = 250;
                    break;
            }
        }

    }
}
