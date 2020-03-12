using DBRepository;
using DBRepository.Interfaces;
using DBRepository.Logger;
using DBRepository.Repositories;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Windows;

namespace Anticafe
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private readonly ILog _log = LogManager.CreateLogger("Desktop", "trace");

		private async void Application_Startup(object sender, StartupEventArgs e)
		{
			_log.Trace("Старт приложения");
			StartWindow window = new StartWindow();

			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
			
			var config = builder.Build();
			IRepositoryContextFactory factory = new RepositoryContextFactory();
			var connectonString = config.GetConnectionString("DefaultConnection");
			using var context = factory.CreateDbContext(connectonString);
			await DbInitializer.Initialize(context);
			_log.Trace("Подключена БД и применена последняя миграция");


			AdministratorInfoRepository admin = new AdministratorInfoRepository(connectonString, factory);

			window.CLogin.ItemsSource = await admin.GetCurrentAdministrator();
			_log.Trace("Выгруженны все администратроры");

			window.Show();
		}
	}
}
