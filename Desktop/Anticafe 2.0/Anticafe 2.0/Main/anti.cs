using System;
using System.Windows.Forms;
using BackEnd;
using Info;
using CloseProject;

namespace Anticafe_2._0
{
    public partial class anti : Form
    {
        private bool EndSmena;

        public anti()
        {
            InitializeComponent();
        }

        private void anti_Load(object sender, EventArgs e)
        {
            TimeOnForm.Tick += new EventHandler(TimeOnForm_Tick);
            TimeOnForm.Enabled = true;
            TimeOnForm.Start();
            Time.Text = DateTime.Now.ToShortTimeString();
            WhoWork.Text = Admin.admin.NameAdmin;

            GuestOut.Enabled = false;

            //чистота и уют не работает
            ToolTip tool = new ToolTip();
            tool.SetToolTip(CHE, "Я заболела, меня лечат. Надеюсь скоро поправлюсь");
        }

        private void TimeOnForm_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void Tarif_Click(object sender, EventArgs e)
        {
            tax form = new tax();
            form.ShowDialog();
        }

        private void NewGuest_Click(object sender, EventArgs e)
        {
            Guest.newGuest form = new Guest.newGuest();
            form.ShowDialog();

            if (Billing.CheckIn)
            {
                Table.Rows.Add();

                Table[0, Billing.LogInValue].Value = Billing.bill[Billing.LogInValue].Name;
                Table[1, Billing.LogInValue].Value = Billing.bill[Billing.LogInValue].Tax;
                Table[2, Billing.LogInValue].Value = Billing.bill[Billing.LogInValue].Flayer;
                Table[3, Billing.LogInValue].Value = Billing.bill[Billing.LogInValue].LogIn.ToShortTimeString();
                Table[7, Billing.LogInValue].Value = false;

                Billing.LogInValue++;
            }

            CheckGuest();
            Admin.admin.BackUp = Admin.admin.SaveBackUp();

        }

        private void GuestOut_Click(object sender, EventArgs e)
        {
            Billing.IdRow = Table.CurrentRow.Index;

            Guest.guestOut form = new Guest.guestOut();
            form.ShowDialog();

            if (Billing.bill[Billing.IdRow].CheckOut)
            {
                Billing.LogOutValue++;

                Table[4, Table.CurrentRow.Index].Value = Billing.bill[Table.CurrentRow.Index].LogOut.ToShortTimeString();
                Table[5, Table.CurrentRow.Index].Value = Billing.bill[Table.CurrentRow.Index].TotalTime;
                Table[6, Table.CurrentRow.Index].Value = Billing.bill[Table.CurrentRow.Index].Money;
                Table[7, Table.CurrentRow.Index].Value = Billing.bill[Table.CurrentRow.Index].Card;

                Table.Rows[Table.CurrentRow.Index].ReadOnly = true;
                Table.Rows[Table.CurrentRow.Index].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
            }

            CheckGuest();
            Admin.admin.BackUp = Admin.admin.SaveBackUp();
        }

        private void SmenaEnd_Click(object sender, EventArgs e)
        {
            smenaEnd form = new smenaEnd();
            EndSmena = true;
            form.ShowDialog();
        }

        /*private void CHE_Click(object sender, EventArgs e)
        {
             clean form = new clean();
             form.Show();
        }
        не забудь убрать коменнтарии в anti.Designer
             */

        private void anti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin.admin.SaveInExcel();
        }

        private void trey_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            ShowInTaskbar = true;
            trey.Visible = false;
        }

        private void anti_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!EndSmena)
            {
                e.Cancel = true;
                Hide();
                ShowInTaskbar = false;
                trey.Visible = true;
            }
            else
            {
                Hide();
                Application.Exit();
            }
        }

        private void Table_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Table.CurrentCell.ColumnIndex == 0)
            {
                if(Table.Rows[Table.CurrentRow.Index].ReadOnly)
                {
                    Table.Rows[Table.CurrentRow.Index].ReadOnly = false;
                    Table.BeginEdit(true);
                    Billing.bill[Table.CurrentRow.Index].Name =
                        Table[Table.CurrentCell.ColumnIndex, Table.CurrentRow.Index].Value.ToString();
                }
                else
                {
                    Table.BeginEdit(true);
                    Billing.bill[Table.CurrentRow.Index].Name =
                        Table[Table.CurrentCell.ColumnIndex, Table.CurrentRow.Index].Value.ToString();
                }
            }

            if (Table.CurrentCell.ColumnIndex == 7)
            {
                if (Table.Rows[Table.CurrentRow.Index].ReadOnly)
                {
                    Table.Rows[Table.CurrentRow.Index].ReadOnly = false;

                    Table.BeginEdit(true);
                    Billing.bill[Table.CurrentRow.Index].Card =
                    (Boolean)Table[Table.CurrentCell.ColumnIndex, Table.CurrentRow.Index].Value;
                }
                else
                {
                    Table.BeginEdit(true);
                    Billing.bill[Table.CurrentRow.Index].Card =
                    (Boolean)Table[Table.CurrentCell.ColumnIndex, Table.CurrentRow.Index].Value;
                }
            }
        }

        private void Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Table.Rows[Table.CurrentRow.Index].DefaultCellStyle.BackColor == System.Drawing.Color.Red)
                Table.Rows[Table.CurrentRow.Index].ReadOnly = true;
            Table.EndEdit();
        }

        private void Table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           Billing.IdRow = Table.CurrentRow.Index;

            DelRow form = new DelRow();
            form.ShowDialog();

            if (Billing.Del)
            {
                Table.Rows.RemoveAt(Billing.IdRow);
                Billing.LogInValue--;
            }

            CheckGuest();
        }

        private void CheckGuest()
        {
            if (Billing.LogInValue > Billing.LogOutValue)
            {
                GuestOut.Enabled = true;
                SmenaEnd.Enabled = false;
            }
            else
            {
                GuestOut.Enabled = false;
                SmenaEnd.Enabled = true;
            }

            if (Billing.LogInValue == Billing.LogOutValue)
                SmenaEnd.Enabled = true;
        }
    }
}