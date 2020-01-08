using System.Windows;

namespace Anticafe
{
    public partial class GuestOut : Window
    {

        public GuestOut()
        {
            InitializeComponent();
        }

		private void BOk_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
