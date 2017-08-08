using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Антикафе_2._0
{
    public partial class Start : Form
    {        
        public Start()
        {
            InitializeComponent();
        }

        private bool StartDay = false;// пременная для суммы в начале дня
		private bool Who = false;// переменная для определения, кто на смене
        private bool HourMer = false;
        private bool MinMer = false;
        private String MerStart = "";

        private void new_day_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(ND.Text, "[0-9]")) 	
			    StartDay = true;

			if (String.IsNullOrWhiteSpace(ND.Text))
				StartDay = false;
            if (!MerFal.Checked)
            {
                if (StartDay && Who && MerFal.Checked)
                    work.Enabled = true;
                else
                    work.Enabled = false;
            }
            else
            {
                if (StartDay && Who && MerTru.Checked && HourMer && MinMer)
                    work.Enabled = true;
                else
                    work.Enabled = false;
            }    
        }

        private void Start_Load(object sender, EventArgs e)
        {
            work.Enabled = false;
            this.Height = 450;
            work.Location = new Point(75, 330);
            MerStartLabel.Visible = false;
            HourMerStart.Visible = false;
            label1.Visible = false;
            MinMerStart.Visible = false;
            TimeStart.Text = DateTime.Now.ToShortTimeString();
        }

        private void work_Click(object sender, EventArgs e)
        {
            anti form = new anti();
            this.Hide();
            function.Day = DateTime.Now.ToShortDateString();
            function.Time = TimeStart.Text;
            function.StartOfDay = Convert.ToInt32(ND.Text);
            function.WhoOnSmena = Smena.Text;
            if (HourMer && MinMer)
            {
                MerStart = HourMerStart.Text + ":" + MinMerStart.Text;
                function.MerStart = Convert.ToDateTime(MerStart);
            }
            form.Show();
        }

        private void smena_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Smena.Text, "[А-Яа-я]"))
                Who = true;

            if (String.IsNullOrWhiteSpace(Smena.Text))
                Who = false;

            if (!MerFal.Checked)
            {
                if (StartDay && Who && MerFal.Checked)
                    work.Enabled = true;
                else
                    work.Enabled = false;
            }
            else
            {
                if (StartDay && Who && MerTru.Checked && HourMer && MinMer)
                    work.Enabled = true;
                else
                    work.Enabled = false;
            }
        }

        private void MerFal_CheckedChanged(object sender, EventArgs e)
        {          
            if (StartDay && Who && MerFal.Checked)
                work.Enabled = true;
            this.Height = 450;
            work.Location = new Point(75, 330);
            MerStartLabel.Visible = false;
            HourMerStart.Visible = false;
            label1.Visible = false;
            MinMerStart.Visible = false;
        }

        private void MerTru_CheckedChanged(object sender, EventArgs e)
        {
            if (StartDay && Who && MerTru.Checked && HourMer && MinMer)
                work.Enabled = true;
            function.CheckMer = true;
            this.Height = 600;
            MerStartLabel.Visible = true;
            HourMerStart.Visible = true;
            label1.Visible = true;
            MinMerStart.Visible = true;
            work.Location = new Point(75, 480);

        }

        private void HourMerStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourMer = true;
        }

        private void MinMerSatrt_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinMer = true;
        }

    }
}

