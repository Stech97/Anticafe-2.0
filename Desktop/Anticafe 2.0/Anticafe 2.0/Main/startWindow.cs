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
        private Int32 NDInt;

        //MerStartLabel.Text = Mer.Text + " начнется в:";

        private void Start_Load(object sender, EventArgs e)
        {
            TimeStart.Text = DateTime.Now.ToShortTimeString();
            work.Enabled = false;
            Mer.Text = "Нет";
            CheckMer();
        }

        private void new_day_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(ND.Text, out NDInt))
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
            if (Regex.IsMatch(Smena.Text, "[А-Яа-я]"))
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
            switch (Mer.Text)
            {
                case "Нет":
                    Event.MafiaCheck = false;
                    Event.EventCheck = false;
                    EventSet = true;
                    CheckWork();
                    CheckMer();
                break;

                case "Мафия":
                    Event.MafiaCheck = true;
                    Event.EventCheck = false;
                    CheckWork();
                    CheckMer();
                break;

                case "Есть":
                    Event.EventCheck = true;
                    Event.MafiaCheck = false;
                    CheckWork();
                    CheckMer();
                break;

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
            Hide();

            if (HourEvent && MinEvent)
            {
                EventStart = HourMerStart.Text + ":" + MinMerStart.Text;
                Event.SetStartEvent(EventStart);
            }

            Admin.admin.SetStartPage(
                Smena.Text, DateTime.Now.Day.ToString(), TimeStart.Text, NDInt);

            form.Show();
        }

        private void CheckWork()
        {
            if (!Event.EventCheck || !Event.MafiaCheck)
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
            if (Event.EventCheck || Event.MafiaCheck)
            {
                Height = 530;
                work.Location = new Point(75, 410);
                MerStartLabel.Visible = true;
                HourMerStart.Visible = true;
                label1.Visible = true;
                MinMerStart.Visible = true;
            }
            else
            {
                Height = 380;
                work.Location = new Point(75, 260);

                MerStartLabel.Visible = false;
                HourMerStart.Visible = false;
                label1.Visible = false;
                MinMerStart.Visible = false;
            }
        }
    }
}

