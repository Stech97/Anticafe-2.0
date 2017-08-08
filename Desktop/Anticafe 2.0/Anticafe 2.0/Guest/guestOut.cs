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
    public partial class guestOut : Form
    {
        private bool flag = false;
        private DateTime DayOut;

        public guestOut()
        {
            InitializeComponent();
        }

        private void guestOut_Load(object sender, EventArgs e)
        {
            if (function.CheckMer)
            {
                tax.Items.Add("Меропр,студудент.");
                tax.Items.Add("Меропр,обычный.");
            }

            if (function.DGV.CurrentRow.DefaultCellStyle.BackColor != Color.Red)
            {
                name.Text = function.DGV.CurrentRow.Cells[0].Value.ToString();
                tax.Text = function.DGV.CurrentRow.Cells[1].Value.ToString();
                flayer.Checked = Convert.ToBoolean(function.DGV.CurrentRow.Cells[2].Value);
                TimeInput.Text = function.DGV.CurrentRow.Cells[3].Value.ToString();
                TimeOutput.Text = DateTime.Now.ToShortTimeString();
                function.TimeOutput = DateTime.Now.TimeOfDay;
                function.HourOutput = DateTime.Now.Hour;
                DayOut = DateTime.Now.Date;

                if (DayOut == function.DayIn)
                {
                    double sum = 0;
                    if ((function.HourInput < 22) && (function.HourOutput < 22))
                    {
                        sum = TimeIsMoney();
                        Sum.Text = Convert.ToString(sum);
                    }
                    if ((function.HourInput < 22) && (function.HourOutput > 21))
                    {
                        if ((tax.Text == "Обычный") || (tax.Text == "Студенческий"))
                        {
                            sum = TimeIsMoney() + (Convert.ToInt16(function.TimeOutput.TotalMinutes - 1320)) * 2;
                            Sum.Text = Convert.ToString(sum);
                        }
                        else
                        {
                            sum = TimeIsMoney();
                            Sum.Text = Convert.ToString(sum);
                        }
                    }
                    if ((function.HourInput > 21) && (function.HourOutput > 21))
                    {
                        sum = Convert.ToInt16(function.TimeOutput.Subtract(function.TimeInput).TotalMinutes * 2);
                        Sum.Text = Convert.ToString(sum);
                    }
                }
                else
                {
                    double sum = 0;
                    if (function.HourInput < 22)
                        if ((function.HourInput < 22) && (function.HourOutput > 21))
                            if ((tax.Text == "Обычный") || (tax.Text == "Студенческий"))
                            {
                                sum = TimeIsMoney() + 240 + (Convert.ToInt16(function.TimeOutput.TotalMinutes - 1320)) * 2;
                                Sum.Text = Convert.ToString(sum);
                            }
                            else
                            {
                                sum = TimeIsMoney();
                                Sum.Text = Convert.ToString(sum);
                            }
                    if (function.HourInput > 21)
                        if ((tax.Text == "Обычный") || (tax.Text == "Студенческий"))
                        {
                            sum = 240 + (Convert.ToInt16(function.TimeOutput.TotalMinutes - 1320)) * 2;
                            Sum.Text = Convert.ToString(sum);
                        }
                        else
                        {
                            sum = TimeIsMoney();
                            Sum.Text = Convert.ToString(sum);
                        }
                    if (function.HourInput < 12)
                        Sum.Text = Convert.ToString(Convert.ToInt16(function.TimeOutput.TotalMinutes) * 2);
                }
                SumCalc.Text = Sum.Text;
                Antiout.Text = "0";
            }
            else
            {
                name.Text =function.DGV.CurrentRow.Cells[0].Value.ToString();
                tax.Text =function.DGV.CurrentRow.Cells[1].Value.ToString();
                flayer.Checked = Convert.ToBoolean(function.DGV.CurrentRow.Cells[2].Value.ToString());
                TimeInput.Text =function.DGV.CurrentRow.Cells[3].Value.ToString();
                TimeOutput.Text =function.DGV.CurrentRow.Cells[4].Value.ToString();
                Sum.Text =function.DGV.CurrentRow.Cells[6].Value.ToString();
                SumCalc.Text = Sum.Text;
                Antiout.Text = "0";
            }
        }

        private void outVis_Click(object sender, EventArgs e)
        {
            if (function.DGV.CurrentRow.DefaultCellStyle.BackColor != Color.Red)
            {
                function.DGV.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                function.DGV.CurrentRow.ReadOnly = true;
                function.DGV.CurrentRow.Cells[1].Value = tax.Text;
                function.DGV.CurrentRow.Cells[2].Value = flayer.Checked;
                function.DGV.CurrentRow.Cells[4].Value = TimeOutput.Text;
                function.DGV.CurrentRow.Cells[5].Value = Convert.ToInt16((function.TimeOutput.Subtract(function.TimeInput)).TotalMinutes);
                function.DGV.CurrentRow.Cells[6].Value = Sum.Text;
                flag = true;
            }
            this.Close();
        }

        private void flayer_CheckedChanged(object sender, EventArgs e)
        {
            if (DayOut == function.DayIn)
            {
                double sum = 0;
                if ((function.HourInput < 22) && (function.HourOutput < 22))
                {
                    sum = TimeIsMoney();
                    Sum.Text = Convert.ToString(sum);
                }
                if ((function.HourInput < 22) && (function.HourOutput > 21))
                {
                    if ((tax.Text == "Обычный") || (tax.Text == "Студенческий"))
                    {
                        sum = TimeIsMoney() + (Convert.ToInt16(function.TimeOutput.TotalMinutes - 1320)) * 2;
                        Sum.Text = Convert.ToString(sum);
                    }
                    else
                    {
                        sum = TimeIsMoney();
                        Sum.Text = Convert.ToString(sum);
                    }
                }
                if ((function.HourInput > 21) && (function.HourOutput > 21))
                {
                    sum = Convert.ToInt16(function.TimeOutput.Subtract(function.TimeInput).TotalMinutes * 2);
                    Sum.Text = Convert.ToString(sum);
                }
            }
            else
            {
                double sum = 0;
                if (function.HourInput < 22)
                    if ((function.HourInput < 22) && (function.HourOutput > 21))
                        if ((tax.Text == "Обычный") || (tax.Text == "Студенческий"))
                        {
                            sum = TimeIsMoney() + 240 + (Convert.ToInt16(function.TimeOutput.TotalMinutes - 1320)) * 2;
                            Sum.Text = Convert.ToString(sum);
                        }
                        else
                        {
                            sum = TimeIsMoney();
                            Sum.Text = Convert.ToString(sum);
                        }
                if (function.HourInput > 21)
                    if ((tax.Text == "Обычный") || (tax.Text == "Студенческий"))
                    {
                        sum = 240 + (Convert.ToInt16(function.TimeOutput.TotalMinutes - 1320)) * 2;
                        Sum.Text = Convert.ToString(sum);
                    }
                    else
                    {
                        sum = TimeIsMoney();
                        Sum.Text = Convert.ToString(sum);
                    }
                if (function.HourInput < 12)
                    Sum.Text = Convert.ToString(Convert.ToInt16(function.TimeOutput.TotalMinutes) * 2);
            }
            SumCalc.Text = Sum.Text;
        }

        private void tax_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DayOut == function.DayIn)
            {
                double sum = 0;
                if ((function.HourInput < 22) && (function.HourOutput < 22))
                {
                    sum = TimeIsMoney();
                    Sum.Text = Convert.ToString(sum);
                }
                if ((function.HourInput < 22) && (function.HourOutput > 21))
                {
                    if ((tax.Text == "Обычный") || (tax.Text == "Студенческий"))
                    {
                        sum = TimeIsMoney() + (Convert.ToInt16(function.TimeOutput.TotalMinutes - 1320)) * 2;
                        Sum.Text = Convert.ToString(sum);
                    }
                    else
                    {
                        sum = TimeIsMoney();
                        Sum.Text = Convert.ToString(sum);
                    }
                }
                if ((function.HourInput > 21) && (function.HourOutput > 21))
                {
                    sum = Convert.ToInt16(function.TimeOutput.Subtract(function.TimeInput).TotalMinutes * 2);
                    Sum.Text = Convert.ToString(sum);
                }
            }
            else
            {
                double sum = 0;
                if (function.HourInput < 22)
                    if ((function.HourInput < 22) && (function.HourOutput > 21))
                        if ((tax.Text == "Обычный") || (tax.Text == "Студенческий"))
                        {
                            sum = TimeIsMoney() + 240 + (Convert.ToInt16(function.TimeOutput.TotalMinutes - 1320)) * 2;
                            Sum.Text = Convert.ToString(sum);
                        }
                        else
                        {
                            sum = TimeIsMoney();
                            Sum.Text = Convert.ToString(sum);
                        }
                if (function.HourInput > 21)
                    if ((tax.Text == "Обычный") || (tax.Text == "Студенческий"))
                    {
                        sum = 240 + (Convert.ToInt16(function.TimeOutput.TotalMinutes - 1320)) * 2;
                        Sum.Text = Convert.ToString(sum);
                    }
                    else
                    {
                        sum = TimeIsMoney();
                        Sum.Text = Convert.ToString(sum);
                    }
                if (function.HourInput < 12)
                    Sum.Text = Convert.ToString(Convert.ToInt16(function.TimeOutput.TotalMinutes) * 2);
            }
            SumCalc.Text = Sum.Text;
            Sum.Refresh();
            SumCalc.Refresh();
        }

        private void guestOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
                function.VisitorOutValue++;
            if ((tax.Text == "Меропр,студудент.") || (tax.Text == "Меропр,обычный."))
                function.MerValue++;
        }

        private void GuestIn_TextChanged(object sender, EventArgs e)
        {
            int AntiOut = 0;
            if (Regex.IsMatch(GuestIn.Text, "[0-9]"))
                AntiOut = Convert.ToInt16(GuestIn.Text) - Convert.ToInt16(SumCalc.Text);
            Antiout.Text = Convert.ToString(AntiOut);
        }

        private int TimeIsMoney()
        {
            double Money = 0;
            double TotalTime = 0;
            if (function.HourOutput < 22)
                TotalTime = Convert.ToDouble((function.TimeOutput.Subtract(function.TimeInput)).TotalMinutes);
            else
                TotalTime = Convert.ToDouble(1320 - function.TimeInput.TotalMinutes);
            if (flayer.Checked)
            {
                switch (tax.Text)
                {
                    case "Обычный":
                        Money = TotalTime * 2;
                        if (TotalTime < 46)
                            Money = 90;
                        Money = Money - 90;
                        break;
                    case "Студенческий":
                        if (TotalTime < 61)
                            Money = 0;
                        if ((TotalTime >= 61) && (TotalTime < 121))
                            Money = (TotalTime - 60) * 1.5;
                        if (TotalTime >= 121)
                            Money = 90 + (TotalTime - 120);
                        break;
                    case "Детский":
                        if (TotalTime < 61)
                            Money = 0;
                        if (TotalTime > 60)
                            Money = (TotalTime - 60);
                        break;
                    case "Меропр,студудент.":
                        if (Convert.ToDateTime(function.TimeInput) >= function.MerStart)
                        {
                            if (function.MerStart.AddHours(3) < Convert.ToDateTime(function.TimeOutput))
                                Money = 250;
                            else
                            {
                                TotalTime = Convert.ToDouble((Convert.ToDateTime(function.TimeOutput) - function.MerStart.AddHours(3)).TotalMinutes);
                                Money = 250 + TotalTime;
                            }
                        }
                        else
                        {
                            TotalTime = Convert.ToDouble((function.MerStart - (Convert.ToDateTime(function.TimeInput))).TotalMinutes)*2;
                            if (function.MerStart.AddHours(3) < Convert.ToDateTime(function.TimeOutput))
                                Money = 250 + TotalTime;
                            else
                            {
                                TotalTime = TotalTime + Convert.ToDouble((Convert.ToDateTime(function.TimeOutput) - function.MerStart.AddHours(3)).TotalMinutes);
                                Money = 250 + TotalTime;
                            }
                        }
                        break;
                    case "Меропр,обычный.":
                        if (Convert.ToDateTime(function.TimeInput) >= function.MerStart)
                        {
                            if (function.MerStart.AddHours(3) < Convert.ToDateTime(function.TimeOutput))
                                Money = 290;
                            else
                            {
                                TotalTime = Convert.ToDouble((Convert.ToDateTime(function.TimeOutput) - function.MerStart.AddHours(3)).TotalMinutes);
                                Money = 290 + TotalTime;
                            }
                        }
                        else
                        {
                            TotalTime = Convert.ToDouble((function.MerStart - (Convert.ToDateTime(function.TimeInput))).TotalMinutes)*2;
                            if (function.MerStart.AddHours(3) < Convert.ToDateTime(function.TimeOutput))
                                Money = 290 + TotalTime;
                            else
                            {
                                TotalTime = TotalTime + Convert.ToDouble((Convert.ToDateTime(function.TimeOutput) - function.MerStart.AddHours(3)).TotalMinutes);
                                Money = 290 + TotalTime;
                            }
                        }
                        break;
                }
                return Convert.ToInt16(Money);
            }
            else
            {
                switch (tax.Text)
                {
                    case "Обычный":
                        Money = TotalTime * 2;
                        if (TotalTime < 46)
                            Money = 90;
                        break;
                    case "Студенческий":
                        if (TotalTime < 61)
                        {
                            Money = TotalTime * 2;
                            if (TotalTime < 46)
                                Money = 90;
                        }
                        if ((TotalTime > 60) && (TotalTime < 121))
                            Money = 120 + (TotalTime - 60) * 1.5;
                        if (TotalTime > 120)
                            Money = 210 + (TotalTime - 120);
                        break;
                    case "Детский":
                        if (TotalTime < 61)
                        {
                            Money = TotalTime * 1.5;
                            if (TotalTime < 46)
                                Money = 90;
                        }
                        if (TotalTime > 60)
                            Money = 90 + (TotalTime - 60);
                        break;
                    case "Меропр,студудент.":
                        if (Convert.ToDateTime(function.TimeInput) >= function.MerStart)
                        {
                            if (function.MerStart.AddHours(3) < Convert.ToDateTime(function.TimeOutput))
                                Money = 250;
                            else
                            {
                                TotalTime = Convert.ToDouble((Convert.ToDateTime(function.TimeOutput) - function.MerStart.AddHours(3)).TotalMinutes);
                                Money = 250 + TotalTime;
                            }
                        }
                        else
                        {
                            TotalTime = Convert.ToDouble((function.MerStart - (Convert.ToDateTime(function.TimeInput))).TotalMinutes) * 2;
                            if (function.MerStart.AddHours(3) < Convert.ToDateTime(function.TimeOutput))
                                Money = 250 + TotalTime;
                            else
                            {
                                TotalTime = TotalTime + Convert.ToDouble((Convert.ToDateTime(function.TimeOutput) - function.MerStart.AddHours(3)).TotalMinutes);
                                Money = 250 + TotalTime;
                            }
                        }
                        break;
                    case "Меропр,обычный.":
                        if (Convert.ToDateTime(function.TimeInput) >= function.MerStart)
                        {
                            if (function.MerStart.AddHours(3) < Convert.ToDateTime(function.TimeOutput))
                                Money = 290;
                            else
                            {
                                TotalTime = Convert.ToDouble((Convert.ToDateTime(function.TimeOutput) - function.MerStart.AddHours(3)).TotalMinutes);
                                Money = 290 + TotalTime;
                            }
                        }
                        else
                        {
                            TotalTime = Convert.ToDouble((function.MerStart - (Convert.ToDateTime(function.TimeInput))).TotalMinutes) * 2;
                            if (function.MerStart.AddHours(3) < Convert.ToDateTime(function.TimeOutput))
                                Money = 290 + TotalTime;
                            else
                            {
                                TotalTime = TotalTime + Convert.ToDouble((Convert.ToDateTime(function.TimeOutput) - function.MerStart.AddHours(3)).TotalMinutes);
                                Money = 290 + TotalTime;
                            }
                        }
                        break;
                }
                return Convert.ToInt16(Money);
            }
        }
    }
}
