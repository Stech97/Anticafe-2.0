using System;
using System.Windows.Forms;
using BackEnd;

namespace Info
{
    public partial class DelRow : Form
    {
        public DelRow()
        {
            InitializeComponent();
        }

        private void DelGuest_Load(object sender, EventArgs e)
        {
            Guest.Text = Billing.bill[Billing.IdRow].Name;
            TPassword.PasswordChar = '*';
        }

        private void DelGuest_Click(object sender, EventArgs e)
        {
            if (Password(TPassword.Text))
            {
                Billing.bill.Remove(Billing.bill[Billing.IdRow]);
                Billing.Del = true;
                this.Close();
            }
            else
            {
                TPassword.Text = "";
                MessageBox.Show("Пароль введен не правильно, повторите попытку", "Не правильный пароль",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private Boolean Password(String pass)
        {
            if (pass == "Timesuffers01022017")
                return true;
            return false;
        }
    }
}
