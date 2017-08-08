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
    public partial class newGuest : Form
    {
        private bool name;
        private bool Tx;

        public newGuest()
        {
            InitializeComponent();
        }

        private void newGuest_Load(object sender, EventArgs e)
        {
            Invite.Enabled = false;
            if (function.CheckMer)
            {
                tax.Items.Add("Меропр,студудент.");
                tax.Items.Add("Меропр,обычный.");
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(FirstName.Text, "[А-Яа-я]")) && !String.IsNullOrWhiteSpace(FirstName.Text))
                name = true;
			
			if (name && Tx)
				Invite.Enabled = true;
        }

        private void tax_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Tx = true;
            if (name && Tx)
                Invite.Enabled = true;
        }

        private void Invite_Click(object sender, EventArgs e)
        {
            function.DGV.Rows.Add();
            function.DGV.Rows[function.VisitorInValue].Cells[0].Value = FirstName.Text;
            function.DGV.Rows[function.VisitorInValue].Cells[1].Value = tax.Text;
            function.DGV.Rows[function.VisitorInValue].Cells[2].Value = Flayer.Checked;
            function.DGV.Rows[function.VisitorInValue].Cells[3].Value = DateTime.Now.ToShortTimeString();
            function.TimeInput = DateTime.Now.TimeOfDay;
            function.HourInput = DateTime.Now.Hour;
            function.VisitorInValue++;
            function.DayIn = DateTime.Now.Date;
            this.Close();
        }
    }
}
