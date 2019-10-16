using System.Windows;
using Anticafe.Model;

namespace Anticafe
{
    public partial class StartWindow : Window
    {
        private readonly Log _log = new Log();
        public StartWindow()
        {
            InitializeComponent();
            _log.Trace("Start application");
        }

		private void BStatrt_Click(object sender, RoutedEventArgs e)
		{
			var mes = "On work: " + TLogin.Text;
            _log.Trace(mes);
			mes = "Start work on: " + TTime.Text;
            _log.Trace(mes);
            _log.Trace("Open main window");

			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Close();
		}
	}
}
