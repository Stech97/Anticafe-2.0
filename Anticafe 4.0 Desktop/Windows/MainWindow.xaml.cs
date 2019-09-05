using System;
using System.Data;
using System.Windows;
using System.Data.Entity;
using Anticafe_4._0_Model;
using System.Data.SqlClient;
using Anticafe_4._0_Model.Models;

namespace Anticafe_4._0
{
    public partial class MainWindow : Window
    {
        public static string WindowTitle { get; set; }

		TestContext db = new TestContext();

		public MainWindow()
        {
            InitializeComponent();

			WindowTitle = "На смене:";

			/*GuestTable.DataContext = db.GuestInfoes.Local.ToBindingList();
			Прписать ModelView для изменнеия ячейки и следующей привязкии её в бд
			Так же изменить строку в бд на свои данные*/
			
			try
			{
				SqlConnection MyConnection = new SqlConnection();
				var cs = MyConnection.State;
				Logger.Log("Connection state: " + cs.ToString());
				db.GuestInfoes.Load();
				GuestTable.ItemsSource = db.GuestInfoes.Local.ToBindingList();
				Logger.Log("Connect to database correct");
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				BNewGuest.IsEnabled = false;
				Logger.Log("Connect to database isn't open" + "\r\n" + "Ошибка:" + e.ToString());  
			}
			catch (System.Data.Entity.Core.EntityException e)
			{
				BNewGuest.IsEnabled = false;
				Logger.Log("Connect to database isn't open" + "\r\n" + "Ошибка:" + e.ToString());
			}
			

		}

		private void BNewGuest_Click(object sender, RoutedEventArgs e)
		{
			NewGuest newGuest = new NewGuest();
			newGuest.ShowDialog();
			db.GuestInfoes.Load();
			GuestTable.ItemsSource = db.GuestInfoes.Local.ToBindingList();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			Visibility = Visibility.Hidden;
		}

		private void NotificayExit_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(1);
			Logger.Log("Close Application with notification icon");
			Logger.Log("Exit");
		}

		private void NotificayVisibly_Click(object sender, RoutedEventArgs e)
		{
			Visibility = Visibility.Visible;
		}
	}
}