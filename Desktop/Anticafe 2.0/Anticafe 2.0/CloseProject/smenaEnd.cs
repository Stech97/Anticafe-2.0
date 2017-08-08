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
    public partial class smenaEnd : Form
    {      
        public smenaEnd()
        {
            InitializeComponent();
        }

        private void smenaEnd_Load(object sender, EventArgs e)
        {
            ND.Text = Convert.ToString(function.StartOfDay);
            Rashod.Text = "0";
            //подсчёт денег за смену
            for (int i = 0; i <function.DGV.RowCount; i++)
                function.SumOnSmena += Convert.ToDouble(function.DGV[6, i].Value);
            Z.Text = Convert.ToString(function.SumOnSmena);
            int itog = function.StartOfDay + Convert.ToInt32(function.SumOnSmena) - function.rashod;
            Itog.Text = Convert.ToString(itog);
        }

        private void Rashod_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Rashod.Text, "[0-9]"))
                function.rashod = Convert.ToInt32(Rashod.Text);
            int itog = function.StartOfDay +  Convert.ToInt32(function.SumOnSmena) - function.rashod;
            Itog.Text = Convert.ToString(itog);
        }

        private void EndSmena_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Application.Exit();
        }
    }
}
