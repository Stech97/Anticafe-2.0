using System.ComponentModel;
using System.Runtime.CompilerServices;
using Anticafe.Model.Models;

namespace Anticafe.ViewModel
{
	public class StartWindow : INotifyPropertyChanged
	{
		private BindingList<AdministratorInfo> _administrators;

		public BindingList<AdministratorInfo> Administrators
		{
			get => _administrators;
			set
			{
				_administrators = value;
				OnPropertyChanged("Administrators");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName]string prop = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

	}
}
