using System;
using System.Windows;

namespace Anticafe_4._0
{
    public partial class MainWindow : Window
    {
        public static string WindowTitle {get; set;}

        public MainWindow()
        {
            WindowTitle = "Антикафе 4.0 На смене:" + Administrator.NameAdmin;
            InitializeComponent();
        }

        private void BTax_Click(object sender, RoutedEventArgs e)
        {
            Tax tax = new Tax();
            tax.Topmost = true;
            tax.ShowDialog();
        }

        private void BNewGuest_Click(object sender, RoutedEventArgs e)
        {
            NewGuest ng = new NewGuest();
            Hide();
            ng.ShowDialog();
            Show();
        }

        private void BGuestOut_Click(object sender, RoutedEventArgs e)
        {
            GuestOut go = new GuestOut();
            Hide();
            go.ShowDialog();
            Show();
        }

        private void BSmenaEnd_Click(object sender, RoutedEventArgs e)
        {
            SmenaEnd se = new SmenaEnd();
            Close();
            se.Show();
        }
    }
}
