using System.Windows;
using System.Windows.Input;


namespace Anticafe_4._0
{
    public partial class GuestIn : Window
    {
        public GuestIn()
        {
            InitializeComponent();
        }

        private void TName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (System.Windows.Forms.InputLanguage.CurrentInputLanguage.Culture.ToString() != "ru-RU") e.Handled = true;
        }

        private void BNew_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
