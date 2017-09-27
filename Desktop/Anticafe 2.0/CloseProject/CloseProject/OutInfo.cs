using System;
using System.Windows.Forms;

namespace CloseProject
{
    public partial class OutInfo : Form
    {
        public OutInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
