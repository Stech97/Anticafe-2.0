using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BackEnd;

namespace Anticafe_2._0
{
    public partial class Start : Form
    {        
        public Start()
        {
            InitializeComponent();
        }

        private Boolean StartDay;
        private Boolean Who;
        private Boolean EventSet;
        private Boolean HourEvent;
        private Boolean MinEvent;
        private String EventStart;


        private void Start_Load(object sender, EventArgs e)
        {
            Admin.admin.Add(new Admin());
            TimeStart.Text = DateTime.Now.ToShortTimeString();
            work.Enabled = false;
            Mer.Text = "Нет";
            CheckMer();
        }

        private void new_day_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(ND.Text, "[0-9]") || !String.IsNullOrWhiteSpace(ND.Text))
            {
                StartDay = true;
                CheckWork();
            }
            else
            {
                StartDay = false;
                CheckWork();
            }
        }
            
        private void smena_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Smena.Text, "[А-Яа-я]") ||
                !String.IsNullOrWhiteSpace(Smena.Text))
            {
                Who = true;
                CheckWork();
            }
            else
            {
                Who = false;
                CheckWork();
            }

        }

        private void Mer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mer.Text == "Есть")
            {
                Event.EventCheck = true;
                CheckWork();
                CheckMer();
            }

            if (Mer.Text == "Нет")
            {
                Event.EventCheck = false;
                EventSet = true;
                CheckWork();
                CheckMer();
            }
        }

        private void HourMerStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourEvent = true;
            CheckWork();
        }

        private void MinMerSatrt_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinEvent = true;
            CheckWork();
        }

        private void work_Click(object sender, EventArgs e)
        {
            anti form = new anti();
            this.Hide();

            if (HourEvent && MinEvent)
            {
                EventStart = HourMerStart.Text + ":" + MinMerStart.Text;
                Event.SetStartEvent(EventStart);
            }

            Admin.admin[0].SetStartPage(
                Smena.Text, DateTime.Now.Day.ToString(), TimeStart.Text, Convert.ToInt32(ND.Text));

            form.Show();
        }

        private void CheckWork()
        {
            if (!Event.EventCheck)
            {
                if (StartDay && Who && EventSet)
                    work.Enabled = true;
                else
                    work.Enabled = false;
            }
            else
            {
                if (StartDay && Who && HourEvent && MinEvent)
                    work.Enabled = true;
                else
                    work.Enabled = false;
            }
        }

        private void CheckMer()
        {
            if (Event.EventCheck)
            {
                this.Height = 530;
                MerStartLabel.Visible = true;
                HourMerStart.Visible = true;
                label1.Visible = true;
                MinMerStart.Visible = true;
                work.Location = new Point(75, 410);
            }
            else
            {
                this.Height = 380;
                work.Location = new Point(75, 260);

                MerStartLabel.Visible = false;
                HourMerStart.Visible = false;
                label1.Visible = false;
                MinMerStart.Visible = false;
            }
        }
    }
}

