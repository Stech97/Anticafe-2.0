using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BackEnd;

namespace Guest
{
    public partial class guestOut :Form
    {
        public guestOut()
        {
            InitializeComponent();
        }

        private void guestOut_Load(object sender, EventArgs e)
        {

            if (!Billing.bill[Billing.IdRow].CheckOut)
            {
                Billing.bill[Billing.IdRow].SetLogOut(DateTime.Now);

                if (Event.EventCheck)
                {
                    tax.Items.Add("Меропр,студудент.");
                    tax.Items.Add("Меропр,обычный.");
                }                 
            }

            name.Text = Billing.bill[Billing.IdRow].Name;
            flayer.Checked = Billing.bill[Billing.IdRow].Flayer;
            Sum.Text = Billing.bill[Billing.IdRow].Money.ToString();
            SumCalc.Text = Sum.Text;
            TimeInput.Text = Billing.bill[Billing.IdRow].LogIn.ToShortTimeString();
            TimeOutput.Text = Billing.bill[Billing.IdRow].LogOut.ToShortTimeString();
            tax.Text = Billing.bill[Billing.IdRow].Tax;
        }

        private void outVis_Click(object sender, EventArgs e)
        {
            Close();
            Billing.bill[Billing.IdRow].CheckOut = true;
        }

        private void flayer_CheckedChanged(object sender, EventArgs e)
        {
            Billing.bill[Billing.IdRow].Flayer = flayer.Checked;

            if ((Billing.bill[Billing.IdRow].Tax == "Меропр,студудент.")
                || (Billing.bill[Billing.IdRow].Tax == "Меропр,обычный."))

                Event.CalcEvent();
            else
                Billing.bill[Billing.IdRow].TimeIsMoney();

            Billing.bill[Billing.IdRow].TimeIsMoney();

            Sum.Text = Billing.bill[Billing.IdRow].Money.ToString();
            SumCalc.Text = Sum.Text;
        }

        private void tax_SelectedIndexChanged(object sender, EventArgs e)
        {
            Billing.bill[Billing.IdRow].Tax = tax.Text;

            if ((Billing.bill[Billing.IdRow].Tax == "Меропр,студудент.")
                || (Billing.bill[Billing.IdRow].Tax == "Меропр,обычный."))

                Event.CalcEvent();
            else
                Billing.bill[Billing.IdRow].TimeIsMoney();

            Sum.Text = Billing.bill[Billing.IdRow].Money.ToString();
            SumCalc.Text = Sum.Text;
        }

        private void GuestInMoney_TextChanged(object sender, EventArgs e)
        {
            Int32 AntiOut = 0;
            if (Regex.IsMatch(GuestIn.Text, "[0-9]"))
                AntiOut = Convert.ToInt32(GuestIn.Text) - 
                    Billing.bill[Billing.IdRow].Money;
            Antiout.Text = AntiOut.ToString();
        }
    }
}
