using Anticafe.Model;
using System.Windows;
using System;

namespace Anticafe
{
    public partial class MainWindow : Window
    {
        private readonly ILog _log;

        public static string WindowTitle = "На смене:";

		public MainWindow()
        {
			/*string admin = GetFromDB. ;
			WindowTitle += " " + admin;*/
			_log = LogManager.CreateLogger("Desktop", "trace");
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
            _log.Trace("Close Application with notification icon");
            _log.Trace("Exit");
            Environment.Exit(1);
        }

		private void NotificayVisibly_Click(object sender, RoutedEventArgs e) => Visibility = Visibility.Visible;

        private void BTax_Click(object sender, RoutedEventArgs e)
		{
			_log.Trace("Open Tax Window");
			Tax tax = new Tax();
			tax.ShowDialog();
			_log.Trace("Close Tax Window");
		}

		private void BGuestIn_Click(object sender, RoutedEventArgs e)
		{
			_log.Trace("Guest In");
			GuestIn GI = new GuestIn();
			GI.ShowDialog();
			_log.Trace("Guest In close");
		}

		private void BGuestOut_Click(object sender, RoutedEventArgs e)
		{
			_log.Trace("Guest Out");
			GuestOut GO = new GuestOut();
			GO.ShowDialog();
			_log.Trace("Guest Out close");
		}

		private void BSmenaEnd_Click(object sender, RoutedEventArgs e)
		{
			_log.Trace("Smena End");
			SmenaEnd smenaEnd = new SmenaEnd();
			smenaEnd.ShowDialog();
			_log.Trace("Smena End and Close");
            _log.Trace("Close Application with code 0");
            _log.Trace("Exit");
            Environment.Exit(0);
		}
	}
}