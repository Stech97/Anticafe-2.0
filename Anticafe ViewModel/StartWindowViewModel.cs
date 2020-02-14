using System;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Anticafe.Model.Models;
using Anticafe.Model;


namespace Anticafe.ViewModel
{
	public class StartWindowViewModel : INotifyPropertyChanged
	{
		private readonly ILog _log;

		private StartWindowCommand _command;
		private BindingList<AdministratorInfo> _administrators;

		public BindingList<AdministratorInfo> Administrators
		{
			get => _administrators;
			set
			{
				_administrators = value;
				OnPropertyChanged("PropertyChanged");
			}
		}

		public string AdminOnSmena { get; set; }
		public string Passsword { get; set; }

		public StartWindowCommand Admin
		{
			get
			{
				return _command ?? (_command = new StartWindowCommand(obj =>
				 {
					 var admin = _administrators.First(x => x.ToString() == AdminOnSmena);
					 admin.TimeStartSmena = DateTime.Now;

					 _log.Trace("На смене: " + admin.Login + " - " + admin.ToString());
					 _log.Trace("Время начала работы: " + admin.TimeStartSmena.ToShortTimeString());
					 SaveToDB.UpdateAdministratorInfoToDB(admin);
				 },
				(obj) => !string.IsNullOrEmpty(AdminOnSmena) && !string.IsNullOrEmpty(Passsword)
				));
			}
		}

		public StartWindowViewModel()
		{
			if (GetFromDB.GetStateDB())
			{
				_log = LogManager.CreateLogger("Desktop", "trace");
				_log.Trace("Старт приложения");

				_administrators = GetFromDB.GetCurrentAdministrator();
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
