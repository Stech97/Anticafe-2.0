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
			var mainWindow = new MainWindow();
			mainWindow.Show();
			Close();
		}
	}
}