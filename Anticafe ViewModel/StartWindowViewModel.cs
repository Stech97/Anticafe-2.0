using System;
using System.Linq;
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
		private StartWindowCommand _command;
		public ObservableCollection<AdministratorInfo> AdministratorInfoes { get; set; }
		
		public AdministratorInfo AdministratorInfos
		{
			get  => _administratorInfo; 
			set
			{
				_administratorInfo = value;
				OnPropertyChanged("Administrators");
			}
		}

		public StartWindowCommand Command
		{
			get
			{
				return _command ??(_command = new StartWindowCommand(obj =>
				{
					var admin = AdministratorInfoes.ToList<AdministratorInfo>();
					var mes = "На смене: " + admin[0].ToString();

					_log.Trace(mes);
					mes = "Время начала работы: " + DateTime.Now.ToShortTimeString();
					_log.Trace(mes);


				}));
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
