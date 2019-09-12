using System.Windows;
using Anticafe_4._0_Model;

namespace Anticafe_4._0
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
			Logger.TraceLog("Start application");
        }

		private void BStatrt_Click(object sender, RoutedEventArgs e)
		{
			var mes = "On work: " + TLogin.Text;
			Logger.TraceLog(mes);
			mes = "Start work on: " + TTime.Text;
			Logger.TraceLog(mes);
			Logger.TraceLog("Open main window");

			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Close();
		}
	}
}
