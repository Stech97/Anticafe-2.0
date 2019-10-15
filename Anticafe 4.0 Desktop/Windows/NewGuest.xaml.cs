using System;
using System.Globalization;
using System.Windows;
using Anticafe.Model;

namespace Anticafe
{
    public partial class NewGuest : Window
    {
        public NewGuest()
        {
            InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            SaveToDB.SaveGuestInfoToDB(BNCard.Text, BName.Text, BSName.Text, BMName.Text, BDis.Text,
                BBD.Text, BEmail.Text, BPhone.Text);
			Close();
		}
	}
}
