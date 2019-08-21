using System.Data;
using System.Windows;
using System.Data.Entity;
using Anticafe_4._0_Model;
using System.Data.SqlClient;
using Anticafe_4._0_Model.Models;
using System;

namespace Anticafe_4._0
{
    public partial class MainWindow : Window, IDisposable
    {
        public static string WindowTitle { get; set; }

		TestContext db = new TestContext();

		public MainWindow()
        {
            InitializeComponent();

			WindowTitle = "На смене:";

			SqlConnection MyConnection = new SqlConnection();
			if (MyConnection.State == ConnectionState.Open)
			{
				db.GuestInfoes.Load();
				GuestTable.DataContext = db.GuestInfoes.Local.ToBindingList();
				var list = db.GuestInfoes.Local.ToBindingList();
				Logger.Log("Connect to database correct");
			}
			else
			{
				BNewGuest.IsEnabled = false;
				Logger.Log("Connect to database isn't open");
			}

		}

		private void BNewGuest_Click(object sender, RoutedEventArgs e)
		{
			using (NewGuest newGuest = new NewGuest())
				newGuest.ShowDialog();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			Visibility = Visibility.Hidden;
		}

		private void NotificayExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown(1);
			Logger.Log("Close Application with notification icon");
			Logger.Log("Exit");
		}

		private void NotificayVisibly_Click(object sender, RoutedEventArgs e)
		{
			Visibility = Visibility.Visible;
		}

		void IDisposable.Dispose()
		{
			throw new NotImplementedException();
		}
	}
}