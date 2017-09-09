using System;
using System.Windows.Forms;

namespace Anticafe_2._0
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
            do
            {
                if (TPassword.Text == " ")
                {
                    Billing.bill.Remove(Billing.bill[Billing.IdRow]);
                    Billing.Del = true;
                }
                else
                {
                    MessageBox.Show("Введен не правильный пароль, попробуйте еще раз", "Неправильный пароль", MessageBoxButtons.OK);
                    TPassword.Text = "";
                    Billing.Del = false;
                }
                if (Billing.Del)
                {
                    Close();
                    break;
                }
            }
            while (Billing.Del);
        }
    }
}
