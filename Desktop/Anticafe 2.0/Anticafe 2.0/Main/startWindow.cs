using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BackEnd;

namespace Anticafe_2._0
{
    public partial class StartWindows : Form
    {        
        public StartWindows()
        {
            InitializeComponent();
        }

        private Boolean StartDay;
        private Boolean Who;
        private Int32 Mer;
        private Boolean HourEvent;
        private Boolean MinEvent;
        private String EventStart;
        private Int32 NDInt;

        private void Start_Load(object sender, EventArgs e)
        {
            startWIndow.Text = DateTime.Now.ToShortTimeString();
            work.Enabled = false;
            colMer.Value = 0;
            Width = 530;
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

        private void colMer_ValueChanged(object sender, EventArgs e)
        {
            switch ((int)colMer.Value)
            {
                case 0:
                    Width = 530;
                    break;
                case 1:
                    Width = 870;
                    break;
                case 2:
                    Width = 1210;
                    break;
            }
        }

        private void work_Click(object sender, EventArgs e)
        {
            anti form = new anti();
            Hide();

            if (HourEvent && MinEvent)
            {
                EventStart = HourMerStart1.Text + ":" + MinMerStart1.Text;
                Event.SetStartEvent(EventStart);
            }

            Admin.admin.SetStartPage(
                Smena.Text, DateTime.Now.Day.ToString(), startWIndow.Text, NDInt);

            form.Show();
        }

        private void Mer11_CheckedChanged(object sender, EventArgs e)
        {
            if (Mer11.Checked)
            {
                Mer = Mer + (Int16)Event.EventList.Event;
                if (colMer.Value == 1)
                {
                    Mer12.Enabled = false;
                    Mer13.Enabled = false;
                }
                if (colMer.Value == 2)
                {
                    Mer12.Enabled = false;
                    Mer13.Enabled = false;
                    Mer21.Enabled = false;
                }
            }
            else
            {
                Mer = Mer - (Int16)Event.EventList.Event;
                if (colMer.Value == 1)
                {
                    Mer12.Enabled = true;
                    Mer13.Enabled = true;
                }
                if (colMer.Value == 2)
                {
                    Mer12.Enabled = true;
                    Mer13.Enabled = true;
                    Mer21.Enabled = true;
                }
            }
            CheckMer();
        }

        private void Mer12_CheckedChanged(object sender, EventArgs e)
        {
            if (Mer12.Checked)
            {
                Mer = Mer + (Int16)Event.EventList.Mafia;
                if (colMer.Value == 1)
                {
                    Mer11.Enabled = false;
                    Mer13.Enabled = false;
                }
                if (colMer.Value == 2)
                {
                    Mer11.Enabled = false;
                    Mer13.Enabled = false;
                    Mer22.Enabled = false;
                } 
            }
            else
            {
                Mer = Mer - (Int16)Event.EventList.Mafia;
                if (colMer.Value == 1)
                {
                    Mer11.Enabled = true;
                    Mer13.Enabled = true;
                }
                if (colMer.Value == 2)
                {
                    Mer11.Enabled = true;
                    Mer13.Enabled = true;
                    Mer22.Enabled = true;
                }
            }

            CheckMer();
        }

        private void Mer13_CheckedChanged(object sender, EventArgs e)
        {
            if (Mer13.Checked)
            {
                Mer = Mer + (Int16)Event.EventList.CinemaNight;
                if (colMer.Value == 1)
                {
                    Mer11.Enabled = false;
                    Mer12.Enabled = false;
                }
                if (colMer.Value == 2)
                {
                    Mer11.Enabled = false;
                    Mer12.Enabled = false;
                    Mer23.Enabled = false;
                }
            }
            else
            {
                Mer = Mer - (Int16)Event.EventList.CinemaNight;
                if (colMer.Value == 1)
                {
                    Mer11.Enabled = true;
                    Mer12.Enabled = true;
                }
                if (colMer.Value == 2)
                {
                    Mer11.Enabled = true;
                    Mer12.Enabled = true;
                    Mer23.Enabled = true;
                }
            }
            CheckMer();
        }

        private void Mer21_CheckedChanged(object sender, EventArgs e)
        {
            if (Mer21.Checked)
            {
                Mer = Mer + (Int16)Event.EventList.Event;
                Mer22.Enabled = false;
                Mer23.Enabled = false;
            }
            else
            {
                Mer = Mer - (Int16)Event.EventList.Event;
                if (Mer12.Checked)
                    Mer22.Enabled = false;
                else
                    Mer22.Enabled = true;

                if (Mer13.Checked)
                    Mer23.Enabled = false;
                else
                    Mer23.Enabled = true;
            }
            CheckMer();
        }

        private void Mer22_CheckedChanged(object sender, EventArgs e)
        {
            if (Mer22.Checked)
            {
                Mer = Mer + (Int16)Event.EventList.Mafia;
                Mer21.Enabled = false;
                Mer23.Enabled = false;
            }
            else
            {
                Mer = Mer - (Int16)Event.EventList.Mafia;
                if (Mer11.Checked)
                    Mer21.Enabled = false;
                else 
                    Mer21.Enabled = true;
                if (Mer13.Checked)
                    Mer23.Enabled = false;
                else
                    Mer23.Enabled = true;
            }
            CheckMer();
        }

        private void Mer23_CheckedChanged(object sender, EventArgs e)
        {
            if (Mer23.Checked)
            {
                Mer = Mer + (Int16)Event.EventList.CinemaNight;
                Mer21.Enabled = false;
            }
            else
            {
                Mer = Mer - (Int16)Event.EventList.CinemaNight;
                Mer21.Enabled = true;
            }
            CheckMer();
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

        //переписать метод.
        private void CheckWork()
        {
            if (!CheckMer())
            {
                if (StartDay && Who)
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

        //выгрузка для мероприятий
        private Boolean CheckMer()
        {
            if (colMer.Value == 1)
            {
                switch (Mer)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    case 2:
                        return true;
                    case 4:
                        return true;
                }
            }

            if (colMer.Value == 2)
            {
                switch (Mer)
                {
                    case 0:
                        return false;
                    case 1:
                        return false;
                    case 2:
                        return false;
                    case 4:
                        return false;
                    case 3:
                        return true;
                    case 5:
                        return true;
                    case 6:
                        return true;
                }
            }

            return false;
        }

    }
}

