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
        
        #region      переменные для регулярок

        private Boolean StartDay;
        private Boolean Who;
        private Int32 NDInt;

        private Int32 kolMer;
        private Boolean HourEvent1;
        private Boolean MinEvent1;
        private Boolean HourEvent2;
        private Boolean MinEvent2;
        private String EventStart1;
        private String EventStart2;
        #endregion

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
            kolMer = (int)colMer.Value;
            switch (kolMer)
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
            Hide();
            anti form = new anti();

            switch (kolMer)
            {
                case 1:
                    EventStart1 = HourMerStart1.Text + ":" + MinMerStart1.Text;
                    Event.SetStartEvent(EventStart1);
                    Event.colMer = kolMer;
                    break;
                case 2:
                    EventStart1 = HourMerStart1.Text + ":" + MinMerStart1.Text;
                    EventStart2 = HourMerStart2.Text + ":" + MinMerStart2.Text;
                    Event.SetStartEvent(EventStart1, EventStart2);
                    Event.colMer = kolMer;
                    break;

            }
            Admin.admin.SetStartPage(
                Smena.Text, DateTime.Now.Day.ToString(), startWIndow.Text, NDInt);

            form.Show();
        }

        private void Mer11_CheckedChanged(object sender, EventArgs e)
        {
            if (Mer11.Checked)
            {
                Event.EList = (Event.EList | Event.EventList.Event);
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
                Event.EList = (Event.EList ^ Event.EventList.Event);
                if (colMer.Value == 1)
                {
                    Mer12.Enabled = true;
                    Mer13.Enabled = true;
                }
                if (colMer.Value == 2)
                {
                    if (Mer22.Checked)
                        Mer12.Enabled = false;
                    else
                        Mer12.Enabled = true;

                    if (Mer23.Checked)
                        Mer13.Enabled = false;
                    else
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
                Event.EList = (Event.EList | Event.EventList.Mafia);
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
                Event.EList = (Event.EList ^ Event.EventList.Mafia);
                if (colMer.Value == 1)
                {
                    Mer11.Enabled = true;
                    Mer13.Enabled = true;
                }
                if (colMer.Value == 2)
                {
                    if (Mer21.Checked)
                        Mer11.Enabled = false;
                    else
                        Mer11.Enabled = true;

                    if (Mer23.Checked)
                        Mer13.Enabled = false;
                    else
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
                Event.EList = (Event.EList | Event.EventList.CinemaNight);
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
                Event.EList = (Event.EList ^ Event.EventList.CinemaNight);
                if (colMer.Value == 1)
                {
                    Mer11.Enabled = true;
                    Mer12.Enabled = true;
                }
                if (colMer.Value == 2)
                {
                    if (Mer21.Checked)
                        Mer11.Enabled = false;
                    else
                        Mer11.Enabled = true;

                    if (Mer22.Checked)
                        Mer12.Enabled = false;
                    else
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
                Event.EList = (Event.EList | Event.EventList.Event);
                Mer22.Enabled = false;
                Mer23.Enabled = false;
                if (Mer11.Enabled && !(Mer12.Checked || Mer13.Checked))
                    Mer11.Enabled = false;
            }
            else
            {
                Event.EList = (Event.EList ^ Event.EventList.Event);
                if (Mer12.Checked)
                    Mer22.Enabled = false;
                else
                    Mer22.Enabled = true;

                if (Mer13.Checked)
                    Mer23.Enabled = false;
                else
                    Mer23.Enabled = true;

                if (!Mer11.Enabled && !(Mer12.Checked || Mer13.Checked))
                    Mer12.Enabled = true;
            }
            CheckMer();
        }

        private void Mer22_CheckedChanged(object sender, EventArgs e)
        {
            if (Mer22.Checked)
            {
                Event.EList = (Event.EList | Event.EventList.Mafia);
                Mer21.Enabled = false;
                Mer23.Enabled = false;
                if (Mer12.Enabled && !(Mer11.Checked || Mer13.Checked))
                    Mer12.Enabled = false;
            }
            else
            {
                Event.EList = (Event.EList ^ Event.EventList.Mafia);
                if (Mer11.Checked)
                    Mer21.Enabled = false;
                else 
                    Mer21.Enabled = true;
                if (Mer13.Checked)
                    Mer23.Enabled = false;
                else
                    Mer23.Enabled = true;
                if (!Mer12.Enabled && !(Mer11.Checked || Mer13.Checked))
                    Mer12.Enabled = true;

            }
            CheckMer();
        }

        private void Mer23_CheckedChanged(object sender, EventArgs e)
        {
            if (Mer23.Checked)
            {
                Event.EList = (Event.EList | Event.EventList.CinemaNight);
                Mer21.Enabled = false;
                Mer22.Enabled = false;
                if (Mer13.Enabled && !(Mer11.Checked || Mer12.Checked))
                    Mer13.Enabled = true;
            }
            else
            {
                Event.EList = (Event.EList ^ Event.EventList.CinemaNight);
                Mer21.Enabled = true;
                Mer22.Enabled = true;
                if (!Mer13.Enabled && !(Mer11.Checked || Mer12.Checked))
                    Mer13.Enabled = false;
            }
            CheckMer();
        }
        
        private void HourMerStart1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourEvent1 = true;
            CheckWork();
        }

        private void MinMerSatrt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinEvent1 = true;
            CheckWork();
        }

        private void HourMerStart2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourEvent2 = true;
            CheckWork();
        }

        private void MinMerStart2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinEvent2 = true;
            CheckWork();
        }

        private void CheckWork()
        {
            switch (kolMer)
            {
                case 0:
                    if (StartDay && Who)
                        work.Enabled = true;
                    else
                        work.Enabled = false;
                    break;
                case 1:
                    if (StartDay && Who && HourEvent1 && MinEvent1 && CheckMer())
                        work.Enabled = true;
                    else
                        work.Enabled = false;
                    break;
                case 2:
                    if (StartDay && Who && HourEvent1 && MinEvent1 && HourEvent2 && MinEvent2 && CheckMer())
                        work.Enabled = true;
                    else
                        work.Enabled = false;
                    break;
            }
        }

        private Boolean CheckMer()
        {
            switch (kolMer)
            {
                case 0:
                    if (Event.EList == Event.EventList.None)
                        return true;
                    else
                        return false;
                case 1:
                    switch (Event.EList)
                    {
                        case Event.EventList.Event:
                            return true;
                        case Event.EventList.Mafia:
                            return true;
                        case Event.EventList.CinemaNight:
                            return true;
                        default:
                            return false;
                    }                    
                case 2:
                    switch (Event.EList)
                    {
                        case (Event.EventList.Event | Event.EventList.Mafia):
                            return true;
                        case (Event.EventList.Mafia | Event.EventList.CinemaNight):
                            return true;
                        case (Event.EventList.Event | Event.EventList.CinemaNight):
                            return true;
                        default:
                            return false;
                    }
            }
            return false;
        }
    }
}

