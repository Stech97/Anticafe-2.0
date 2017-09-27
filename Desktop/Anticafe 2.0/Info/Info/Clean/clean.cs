using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Антикафе_2._0.Info.Clean
{
    public partial class clean : Form
    {
        public clean()
        {
            InitializeComponent();
        }

        private void clean_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
            switch (DateTime.Now.DayOfWeek.ToString())
            { 
                case "Sunday":
                        DayOfWeek.Text = "Воскресенье";
                        break;
                case "Monday":
                        DayOfWeek.Text = "Понедельник";
                        break;
                case "Tuesday":
                        DayOfWeek.Text = "Вторник";
                        break;
                case "Wednesday":
                        DayOfWeek.Text = "Среда";
                        break;
                case "Thursday":
                    DayOfWeek.Text = "Четверг";
                        break;
                case "Friday":
                        DayOfWeek.Text = "Пятница";
                        break;
                case "Saturday":
                        DayOfWeek.Text = "Суббота";
                        break;
            }
        }

        private void Mon_Click(object sender, EventArgs e)
        {
            Mon form = new Mon();
            form.Show();
        }

        private void Tue_Click(object sender, EventArgs e)
        {
            Thu form = new Thu();
            form.Show();
        }

        private void Wen_Click(object sender, EventArgs e)
        {
            Wen form = new Wen();
            form.Show();
        }

        private void The_Click(object sender, EventArgs e)
        {
            The form = new The();
            form.Show();
        }

        private void Fri_Click(object sender, EventArgs e)
        {
            Fri form = new Fri();
            form.Show();
        }

        private void Sat_Click(object sender, EventArgs e)
        {
            Sat form = new Sat();
            form.Show();
        }

        private void Sun_Click(object sender, EventArgs e)
        {
            Sun form = new Sun();
            form.Show();
        } 
    }
}
