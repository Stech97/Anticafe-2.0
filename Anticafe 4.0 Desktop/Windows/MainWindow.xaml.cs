using System.Windows;
using Anticafe_4._0_Model;
using System.Data.Entity;

namespace Anticafe_4._0
{
    public partial class MainWindow : Window
    {
        public static string WindowTitle { get; set; }

		GuestInfoContext db = new GuestInfoContext();

		public MainWindow()
        {
            InitializeComponent();
			db.GuestInfo.Load();
			GuestTable.DataContext = db.GuestInfo.Local.ToBindingList();
			var list = db.GuestInfo.Local.ToBindingList();
		}

		private void GuestTable_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
		{
			GuestTable.DataContext = db.GuestInfo.Local.ToBindingList();
			
		}

		private void BNewGuest_Click(object sender, RoutedEventArgs e)
		{
			NewGuest NG = new NewGuest();
			NG.Show();
		}
	}
}
