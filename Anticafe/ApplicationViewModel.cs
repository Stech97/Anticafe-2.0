using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using Anticafe.Model;
using DBRepository.Interfaces;
using Microsoft.Extensions.Configuration;
using System.IO;
using DBRepository;
using DBRepository.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using DBRepository.Logger;

namespace Anticafe
{
	public class ApplicationViewModel : INotifyPropertyChanged
	{
		private readonly ILog _log = LogManager.CreateLogger("Desktop", "trace");
		private AdministratorInfo administrator;

		public ObservableCollection<AdministratorInfo> Administrators { get; set; }

		public AdministratorInfo Administrator
		{
			get { return administrator; }
			set
			{
				administrator = value;
				OnPropertyChanged("SelectAdmin");
			}
		}
		public ApplicationViewModel()
		{
			_log.Trace("Старт приложения");
			List<AdministratorInfo> infos = Task.Run(() => DB()).Result;
			Administrators = new ObservableCollection<AdministratorInfo>(infos);
			_log.Trace("Выгруженны все администратроры");
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}


		private async Task<List<AdministratorInfo>> DB()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

			var config = builder.Build();
			IRepositoryContextFactory factory = new RepositoryContextFactory();
			var connectonString = config.GetConnectionString("DefaultConnection");
			using var context = factory.CreateDbContext(connectonString);
			await DbInitializer.Initialize(context);
			//_log.Trace("Подключена БД и применена последняя миграция");


			AdministratorInfoRepository admin = new AdministratorInfoRepository(connectonString, factory);

			return await admin.GetCurrentAdministrator();
		}

	}
}
