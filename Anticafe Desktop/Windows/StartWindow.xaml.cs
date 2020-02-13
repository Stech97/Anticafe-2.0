using Anticafe.ViewModel;
using System.Windows;

namespace Anticafe
{
    public partial class StartWindow : Window
    {
		public StartWindow()
		{
			InitializeComponent();
			DataContext = new StartWindowViewModel();
		}
		private void BStatrt_Click(object sender, RoutedEventArgs e)
		{
			//var mes = "На смене:" + CLogin.Text;
			//_log.Trace(mes);
			//mes = "Время начала работы:" + TTime.Text;
			//_log.Trace(mes);

			var mainWindow = new MainWindow();
			mainWindow.Show();
			Close();
		}

	}
}