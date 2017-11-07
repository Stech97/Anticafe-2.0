using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BackEnd;

namespace CloseProject
{
    public partial class smenaEnd : Form
    {      
        public smenaEnd()
        { 
            InitializeComponent();
        }

        private void smenaEnd_Load(object sender, EventArgs e)
        {
            ND.Text = Admin.admin.SumLogIn.ToString();
            SumPrazdnik.Text = "0";
            Rashod.Text = "0";

            Z.Text = Admin.admin.CalcTotalSum().ToString();

            Itog.Text = Admin.admin.CalcItog().ToString();
        }

        private void Rashod_TextChanged(object sender, EventArgs e)
        {
           if (Regex.IsMatch(Rashod.Text, "[0-9]"))
                Admin.admin.Rashod = Convert.ToInt32(Rashod.Text);

            Itog.Text = Admin.admin.CalcItog().ToString();
        }

        private void SumPrazdnik_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(SumPrazdnik.Text, "[0-9]"))
                Admin.admin.SumInPrazdnik = Convert.ToInt32(SumPrazdnik.Text);

            Itog.Text = Admin.admin.CalcItog().ToString();
        }

        private void EndSmena_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            OutInfo form = new OutInfo();
            form.ShowDialog();
            Application.Exit();
        }


    }
}
