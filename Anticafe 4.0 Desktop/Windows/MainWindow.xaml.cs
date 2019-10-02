using Anticafe_4._0_Model;
using System.Windows;
using System;

namespace Anticafe_4._0
{
    public partial class MainWindow : Window
    {
		public static string WindowTitle = "На смене:" + "admin";

		public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (GetFromDB.GetStateDB())
                GuestTable.ItemsSource = GetFromDB.GetGuestInfo();
            else
                BNewGuest.IsEnabled = false;
        }
        private void BNewGuest_Click(object sender, RoutedEventArgs e)
		{
			NewGuest newGuest = new NewGuest();
			newGuest.ShowDialog();
            GuestTable.ItemsSource = GetFromDB.GetGuestInfo();
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