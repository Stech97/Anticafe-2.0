using System.Windows;
using Anticafe.Model;

namespace Anticafe
{
    public partial class StartWindow : Window
    {
        private readonly ILog log;
        public StartWindow()
        {
            InitializeComponent();   
			log.Trace("Start application");
        }

		private void BStatrt_Click(object sender, RoutedEventArgs e)
		{
			var mes = "On work: " + TLogin.Text;
			log.Trace(mes);
			mes = "Start work on: " + TTime.Text;
            log.Trace(mes);
            log.Trace("Open main window");

			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Close();
		}
	}
}
