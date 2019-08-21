using System.Windows;
using Anticafe_4._0_Model;

namespace Anticafe_4._0
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
			Logger.Log("Start application");
        }

		private void BStatrt_Click(object sender, RoutedEventArgs e)
		{
			var mes = "On work: " + TLogin.Text;
			Logger.Log(mes);
			mes = "Start work on: " + TTime.Text;
			Logger.Log(mes);
			Logger.Log("Open main window");

			MainWindow Window = new MainWindow();
			Window.Show();
			Close();
		}
	}
}
