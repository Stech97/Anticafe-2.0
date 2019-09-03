using System;
using System.Windows;
using Anticafe_4._0_Model.Models;

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
			TestContext db = new TestContext();

			GuestInfo gi = new GuestInfo
			{
				FirstName = BName.Text,
				SecondName = BSName.Text,
				MiddleName = BMName.Text,
				Discount = int.Parse(BDis.Text),
				BDay = DateTime.Parse(BBD.Text),
				Email = BEmail.Text,
				Phone = BPhone.Text
			};

			db.GuestInfoes.Add(gi);
			db.SaveChanges();
			Close();
		}
	}
}
