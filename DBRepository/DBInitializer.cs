using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;

namespace DBRepository
{
	public static class DbInitializer
	{
		public async static Task Initialize(RepositoryContext context)
		{
			await context.Database.MigrateAsync();

			var adminCount = await context.AdministratorInfos.CountAsync().ConfigureAwait(false);

			if (adminCount == 0)
			{
				context.AdministratorInfos.Add(new Anticafe.Model.AdministratorInfo()
				{
					Login = "admin",
					Password = "admin",
					NumberCard = "0",
					FirstName = "Администратор",
					SecondName = "Системы",
					MiddleName = " ",
					BDay = DateTime.Now.Date,
					Email = " ",
					Phone = " ",
					TimeStartSmena = DateTime.Now
				});
				await context.SaveChangesAsync().ConfigureAwait(false);
			}
		}
	}
}
