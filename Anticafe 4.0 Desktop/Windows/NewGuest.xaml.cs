using System;
using System.Windows;
using Anticafe_4._0_Model;
using Anticafe_4._0_Model.Entity;

namespace Anticafe_4._0
{
    public partial class NewGuest : Window
    {
        public NewGuest()
        {
            InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			DBConnect db = new DBConnect();

			GuestInfo gi = new GuestInfo
			{
				//поменять на динамичское добавление
				ID = 10,
				FirstName = BName.Text,
				SecondName = BSName.Text,
				MiddleName = BMName.Text,
				Discount = int.Parse(BDis.Text),
				BDay = DateTime.Parse(BBD.Text),
				Email = BEmail.Text
			};

			db.AddGuestInfo(gi);
			Close();
		}
	}
}
