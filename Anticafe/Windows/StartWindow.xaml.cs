using System.Windows;
using DBRepository.Logger;

namespace Anticafe
{
    public partial class StartWindow : Window
    {
		private readonly ILog _log = LogManager.CreateLogger("Desktop", "trace");

		public StartWindow() => InitializeComponent();
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