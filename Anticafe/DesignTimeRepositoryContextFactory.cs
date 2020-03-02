using DBRepository;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;

namespace Anticafe.Desktop
{
	public class DesignTimeRepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
	{
		public RepositoryContext CreateDbContext(string[] args)
		{
			var builder = new ConfigurationBuilder()
				 .SetBasePath(Directory.GetCurrentDirectory())
				 .AddJsonFile("appsettings.json");

			var config = builder.Build();
			var connectionString = config.GetConnectionString("DefaultConnection");
			var repositoryFactory = new RepositoryContextFactory();

			return repositoryFactory.CreateDbContext(connectionString);
		}
	}
}
