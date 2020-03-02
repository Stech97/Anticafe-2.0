using System;
using System.Windows;
using Anticafe.Model;
using System.Windows.Input;
using System.Windows.Controls;

namespace Anticafe
{
    public partial class StartWindow : Window
    {
		private readonly ILog _log;

		public StartWindow()
		{
			_log = LogManager.CreateLogger("Desktop", "trace");
			_log.Trace("Старт приложения");
			InitializeComponent();
			//DataContext = new ;
		}
		private void BStatrt_Click(object sender, RoutedEventArgs e)
		{
			var mes = "На смене:" + CLogin.Text;
            _log.Trace(mes);
			mes = "Время начала работы:" + TTime.Text;
            _log.Trace(mes);

			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Close();
		}

	}
}