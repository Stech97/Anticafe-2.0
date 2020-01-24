using Anticafe.Model;
using System.Windows;
using System;


/*
	сделать взаимодействие с кнопками через command для ViewModel во всех окнах
*/
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

            InitializeComponent();

			_log = LogManager.CreateLogger("Desktop", "trace");
			_log.Trace("Открыто основное окно");
			GuestTable.ItemsSource = GetFromDB.GetGuestInfo();

		}

        private void BNewGuest_Click(object sender, RoutedEventArgs e)
		{
			_log.Trace("Открыто окно \"Новый гость\"");
			NewGuest newGuest = new NewGuest();
			newGuest.ShowDialog();
            GuestTable.ItemsSource = GetFromDB.GetGuestInfo();
			_log.Trace("Закрыто окно \"Новый гость\"");
		}

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			Visibility = Visibility.Hidden;
		}

        private void NotificayExit_Click(object sender, RoutedEventArgs e)
		{
            _log.Trace("Приложение закрыто через значок уведомления");
            _log.Trace("Exit");
            Environment.Exit(1);
        }

		private void NotificayVisibly_Click(object sender, RoutedEventArgs e)
		{
			if (!WindowState.Equals(WindowState.Maximized))
			{
				WindowState = WindowState.Normal;
				Visibility = Visibility.Visible;
				WindowState = WindowState.Maximized;
			}				
			else
				Visibility = Visibility.Visible;
		}

        private void BTax_Click(object sender, RoutedEventArgs e)
		{
			_log.Trace("Открыто окно \"Тарифы\"");
			Tax tax = new Tax();
			tax.ShowDialog();
			_log.Trace("Закрыто окно \"Тарифы\"");
		}

		private void BGuestIn_Click(object sender, RoutedEventArgs e)
		{
			_log.Trace("Открыто окно \"Гость пришёл\"");
			GuestIn GI = new GuestIn();
			GI.ShowDialog();
			_log.Trace("Закрыто окно \"Гость пришёл\"");
		}

		private void BGuestOut_Click(object sender, RoutedEventArgs e)
		{
			_log.Trace("Открыто окно \"Гость уходит\"");
			GuestOut GO = new GuestOut();
			GO.ShowDialog();
			_log.Trace("Закрыто окно \"Гость уходит\"");
		}

		private void BSmenaEnd_Click(object sender, RoutedEventArgs e)
		{
			_log.Trace("Открыто окно \"Конец смены\"");
			SmenaEnd smenaEnd = new SmenaEnd();
			_log.Trace("Закрыто окно \"Конец смены\"");
			smenaEnd.ShowDialog();
			_log.Trace("Смена закрыта");
            _log.Trace("Приложение закрыто с кодом 0");
            _log.Trace("Exit");
            Environment.Exit(0);
		}
	}
}