using System;
using System.Windows;
using System.Windows.Input;


namespace Anticafe_4._0
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void TSum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0)) e.Handled = true;
        }
        private void TOnSmena_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (System.Windows.Forms.InputLanguage.CurrentInputLanguage.Culture.ToString() != "ru-RU") e.Handled = true;
        }
        private void BStatrt_Click(object sender, RoutedEventArgs e)
        {
            Administrator.NameAdmin = TOnSmena.Text;
            Administrator.StartSum = int.Parse(TSum.Text);
            Administrator.StartTime = DateTime.Now;
            //Добавить код, когда придумаю что делать с мероприятиями

            MainWindow anti = new MainWindow();
            anti.Show();
            Close();
        }
       
    }
}
