using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Anticafe_2._0
{
    public partial class smenaEnd : Form
    {      
        public smenaEnd()
        { 
            InitializeComponent();
        }

        private void smenaEnd_Load(object sender, EventArgs e)
        {
            ND.Text = Admin.admin[0].SumLogIn.ToString();
            SumPrazdnik.Text = "0";
            Rashod.Text = "0";

            Z.Text = Admin.admin[0].CalcTotalSum().ToString();

            Itog.Text = Admin.admin[0].CalcItog().ToString();
        }

        private void Rashod_TextChanged(object sender, EventArgs e)
        {
           if (Regex.IsMatch(Rashod.Text, "[0-9]"))
                Admin.admin[0].Rashod = Convert.ToInt32(Rashod.Text);

            Itog.Text = Admin.admin[0].CalcItog().ToString();
        }

        private void SumPrazdnik_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(SumPrazdnik.Text, "[0-9]"))
                Admin.admin[0].SumInPrazdnik = Convert.ToInt32(SumPrazdnik.Text);

            Itog.Text = Admin.admin[0].CalcItog().ToString();
        }

        private void EndSmena_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            OutInfo form = new OutInfo();
            form.ShowDialog();
            Application.Exit();
        }


    }
}
