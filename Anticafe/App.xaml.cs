using DBRepository;
using DBRepository.Interfaces;
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
		private readonly IRepositoryContextFactory contextFactory;

	private async void Application_Startup(object sender, StartupEventArgs e)
		{
			StartWindow window = new StartWindow();

			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory()).
				AddJsonFile("appsettings.json");
			var config = builder.Build();
			var factory = new RepositoryContextFactory();
			var connectonString = config.GetConnectionString("DefaultConnection");
			using var context = factory.CreateDbContext(connectonString);
			await DbInitializer.Initialize(context);

			AdministratorInfoRepository administratorInfoRepository =
				new AdministratorInfoRepository(connectonString, contextFactory);

			window.CLogin.DataContext = administratorInfoRepository.GetCurrentAdministrator();
			window.Show();
		}
	}
}
