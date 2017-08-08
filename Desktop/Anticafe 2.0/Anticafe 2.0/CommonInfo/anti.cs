using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Controls;
//using Disk.SDK;
//using Disk.SDK.Provider;
//using Disk.SDK.Utils;



namespace Антикафе_2._0
{
    public partial class anti : Form
    {
        //private Disk.SDK.DiskSdkClient Disk;
        //private Disk.SDK.DiskItemInfo DiskInfo;
        //internal System.Windows.Controls.WebBrowser browser;
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

            WhoWork.Text = function.WhoOnSmena;

            GuestOut.Enabled = false;
            CHE.Enabled = false;
        }

        private void TimeOnForm_Tick(object sender, EventArgs e)
        {
            Time.Value = DateTime.Now;
        }

        private void Tarif_Click(object sender, EventArgs e)
        {
            tax form = new tax();
            form.ShowDialog();
        }

        private void NewGuest_Click(object sender, EventArgs e)
        {
            newGuest form = new newGuest();
            function.DGV = Table;
            form.ShowDialog();
            if (function.VisitorInValue > function.VisitorOutValue)
            {
                GuestOut.Enabled = true;
                SmenaEnd.Enabled = false;
            }
            Table = function.DGV;
        }

        private void GuestOut_Click(object sender, EventArgs e)
        {       
            guestOut form = new guestOut();
            function.DGV = Table;
            form.ShowDialog();
            if (function.VisitorInValue == function.VisitorOutValue)
                SmenaEnd.Enabled = true;
            Table = function.DGV;
        }

        private void SmenaEnd_Click(object sender, EventArgs e)
        {
            function.DGV = Table;
            smenaEnd form = new smenaEnd();
            EndSmena = true;
            form.ShowDialog();
        }

        private void CHE_Click(object sender, EventArgs e)
        {
            Антикафе_2._0.Info.Clean.clean form = new Антикафе_2._0.Info.Clean.clean();
            form.ShowDialog();
        }

        private void anti_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string nav = "https://oauth.yandex.ru/authorize?response_type=token&client_id=c86cc54948f8474e9a74a909d16838d7";
            /*browser = new System.Windows.Controls.WebBrowser();
            Disk.AuthorizeAsync(new WebBrowserWrapper(browser), "c86cc54948f8474e9a74a909d16838d7", "https://oauth.yandex.ru/verification_code", this.CompleteCallback);
            Disk = new Disk.SDK.DiskSdkClient();
            DiskInfo = new Disk.SDK.DiskItemInfo();
            Disk.MakeDirectoryAsync("Сметки\\" + Year + " год\\" + Month);*/
           function.DGV = Table;
           function.SaveInExcel();
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
        
        /*private void CompleteCallback(object sender, GenericSdkEventArgs<string> e)
        {
            if (this.AuthCompleted != null)
                this.AuthCompleted(this, new GenericSdkEventArgs<string>(e.Result));
            this.Close();
        }
        //Api яндекс Диска. Я не знаю как это работает, но это нужно(строка выше и ниже)
        //public event EventHandler<GenericSdkEventArgs<string>> AuthCompleted;*/

    }
}