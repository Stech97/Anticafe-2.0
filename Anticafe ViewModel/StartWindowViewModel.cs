using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Anticafe.Model.Models;
using Anticafe.Model;


namespace Anticafe.ViewModel
{
	public class StartWindowViewModel : INotifyPropertyChanged
	{
		private readonly ILog _log;
		private AdministratorInfo _administratorInfo;
		public ObservableCollection<AdministratorInfo> AdministratorInfoes { get; set; }
		public AdministratorInfo LoadAdministratorInfo
		{
			get  => _administratorInfo; 
			set
			{
				_administratorInfo = value;
				OnPropertyChanged("LoadCLogin");
			}
		}

		public StartWindowViewModel()
		{
			if (GetFromDB.GetStateDB())
			{
				_log = LogManager.CreateLogger("Desktop", "trace");
				_log.Trace("Старт приложения");

				AdministratorInfoes = new ObservableCollection<AdministratorInfo>();
				AdministratorInfoes = GetFromDB.GetCurrentAdministrator();
			}
			else
			{
				_log.Info("Завершение работы");
				Environment.Exit(-1);
			}
		}

        public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
	}
}
