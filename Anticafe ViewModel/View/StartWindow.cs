using System.ComponentModel;
using System.Runtime.CompilerServices;
using Anticafe.Model.Models;
using Anticafe.Model;

namespace Anticafe.ViewModel
{
	public class StartWindow : INotifyPropertyChanged
	{
		private static ILog _log;

		private BindingList<AdministratorInfo> _administrators;

		public BindingList<AdministratorInfo> Administrators
		{
			get { return _administrators; }
			set
			{
				_administrators = value;
				OnPropertyChanged("CLogin");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
