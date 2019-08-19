using System.Windows;

namespace Anticafe_4._0
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

		private void BStatrt_Click(object sender, RoutedEventArgs e)
		{
			MainWindow Window = new MainWindow();
			Window.Show();
			Hide();
		}
	}
}
