using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BackEnd;

namespace Guest
{
    public partial class newGuest :Form
    {
        private Boolean name;
        private Boolean Tx;

        public newGuest()
        {
            InitializeComponent();
        }

        private void newGuest_Load(object sender, EventArgs e)
        {
            Invite.Enabled = false;
            if (Event.EventCheck)
            {
                tax.Items.Add("Меропр,студудент.");
                tax.Items.Add("Меропр,обычный.");
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(FirstName.Text, "[А-Яа-я]")) || !String.IsNullOrWhiteSpace(FirstName.Text))
            {
                name = true;
                CheckGuest();
            }
        }

        private void tax_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Tx = true;
            CheckGuest();
        }

        private void Invite_Click(object sender, EventArgs e)
        {
            Billing.CheckIn = true;
            Close();
        }

        private void newGuest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Billing.CheckIn)
            {
                Billing.bill.Add(new Billing());
                Billing.bill[Billing.LogInValue].SetLogIn(FirstName.Text, tax.Text,
                    Flayer.Checked, DateTime.Now);
                if ((Billing.bill[Billing.LogInValue].Tax == "Меропр,студудент.")
                    || (Billing.bill[Billing.LogInValue].Tax == "Меропр,обычный."))
                        Event.EventValue++;
            }
        }

        private void CheckGuest()
        {
            if (name && Tx)
                Invite.Enabled = true;
            else
                Invite.Enabled = false;
        }
    }
}
