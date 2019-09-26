using System;
using System.Windows;
using System.Data.Entity;
using Anticafe_4._0_Model;
using System.Data.SqlClient;
using Anticafe_4._0_Model.Models;

namespace Anticafe_4._0
{
    public partial class MainWindow : Window
    {
		private const string ConnectionString = @"Data Source=MAX-PC\ANTICAFE_DB;Initial Catalog=Test;Integrated Security=True;MultipleActiveResultSets=True";
		public static string WindowTitle = "На смене:" + "admin";

		private readonly TestContext _context = new TestContext();

		public MainWindow()
        {
            InitializeComponent();

			/*GuestTable.DataContext = db.GuestInfoes.Local.ToBindingList();
			Прписать ModelView для изменнеия ячейки и следующей привязкии её в бд
			Так же изменить строку в бд на свои данные*/

			try
			{
				var mSqlConnectionyConnection = new SqlConnection(connectionString: ConnectionString);
				var cs = mSqlConnectionyConnection.State;
				Logger.TraceLog("Connection state: " + cs.ToString());
				_context.GuestInfoes.Load();
				GuestTable.ItemsSource = _context.GuestInfoes.Local.ToBindingList();
				Logger.TraceLog("Connect to database correct");
			}
			catch (SqlException e)
			{
				BNewGuest.IsEnabled = false;
				Logger.ExeptionLog("Connect to database isn't open" + "\r\n" + "Ошибка:" + e.ToString());  
			}
			catch (System.Data.Entity.Core.EntityException e)
			{
				BNewGuest.IsEnabled = false;
				Logger.ExeptionLog("Connect to database isn't open" + "\r\n" + "Ошибка:" + e.ToString());

            }
			

		}

		private void BNewGuest_Click(object sender, RoutedEventArgs e)
		{
			NewGuest newGuest = new NewGuest();
			newGuest.ShowDialog();
			_context.GuestInfoes.Load();
			GuestTable.ItemsSource = _context.GuestInfoes.Local.ToBindingList();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			Visibility = Visibility.Hidden;
		}

        private void NotificayExit_Click(object sender, RoutedEventArgs e)
		{
            Logger.TraceLog("Close Application with notification icon");
            Logger.TraceLog("Exit");
            Environment.Exit(1);
        }

		private void NotificayVisibly_Click(object sender, RoutedEventArgs e) => Visibility = Visibility.Visible;

        private void BTax_Click(object sender, RoutedEventArgs e)
		{
			Logger.TraceLog("Open Tax Window");
			Tax tax = new Tax();
			tax.ShowDialog();
			Logger.TraceLog("Close Tax Window");
		}

		private void BGuestIn_Click(object sender, RoutedEventArgs e)
		{
			Logger.TraceLog("Guest In");
			GuestIn GI = new GuestIn();
			GI.ShowDialog();
			Logger.TraceLog("Guest In close");
		}

		private void BGuestOut_Click(object sender, RoutedEventArgs e)
		{
			Logger.TraceLog("Guest Out");
			GuestOut GO = new GuestOut();
			GO.ShowDialog();
			Logger.TraceLog("Guest Out close");
		}

		private void BSmenaEnd_Click(object sender, RoutedEventArgs e)
		{
			Logger.TraceLog("Smena End");
			SmenaEnd smenaEnd = new SmenaEnd();
			smenaEnd.ShowDialog();
			Logger.TraceLog("Smena End and Close");
            Logger.TraceLog("Close Application with code 0");
            Logger.TraceLog("Exit");
            Environment.Exit(0);
		}
	}
}