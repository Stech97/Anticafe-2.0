using System.Windows;
using System.Windows.Input;

namespace Anticafe_4._0
{
    public partial class SmenaEnd : Window
    {
        public SmenaEnd()
        {
            InitializeComponent();
        }

        private void SumHP_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void BEnd_Click(object sender, RoutedEventArgs e)
        {
            //сохранение всех данных
            Application.Current.Shutdown(0);
        }
    }
}
