using System.Windows;
using Anticafe_4._0_Model.Models;
using System.Data.Entity;

namespace Anticafe_4._0
{
    public partial class MainWindow : Window
    {
        public static string WindowTitle { get; set; }

		TestContext db = new TestContext();

		public MainWindow()
        {
            InitializeComponent();
			db.GuestInfoes.Load();
			GuestTable.DataContext = db.GuestInfoes.Local.ToBindingList();
			var list = db.GuestInfoes.Local.ToBindingList();
		}

		private void GuestTable_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
		{
			GuestTable.DataContext = db.GuestInfoes.Local.ToBindingList();
			
		}

		private void BNewGuest_Click(object sender, RoutedEventArgs e)
		{
			NewGuest NG = new NewGuest();
			NG.Show();
		}
	}
}
