using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace Anticafe_4._0
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            TSum.PreviewTextInput += new TextCompositionEventHandler(TSum_PreviewTextInput);
        }

        private void TSum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0)) e.Handled = true;
        }
        private void TOnSmena_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.ToString() != "ru-RU") e.Handled = true;
        }


        private void BStatrt_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
