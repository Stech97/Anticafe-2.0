using Anticafe.Model;
using DBRepository.Interfaces;
using DBRepository.Logger;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBRepository.Repositories
{
	public class AdministratorInfoRepository : BaseRepository, IAdministratorInfoRepository
	{
		private static readonly ILog _log = LogManager.CreateLogger("BackEnd", "trace");

		public AdministratorInfoRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

		public async Task SaveAdministratorInfo(AdministratorInfo administratorInfo) 
		{
			using (var context = ContextFactory.CreateDbContext(ConnectionString))
			{
				context.AdministratorInfos.Add(administratorInfo);
				await context.SaveChangesAsync();
			}

			_log.Trace("Добавлен новый администратор " + administratorInfo.ToString());
		}

		public async Task UpdateAdministratorInfoToDB(AdministratorInfo administratorInfo)
		{
			using (var context = ContextFactory.CreateDbContext(ConnectionString))
			{
				context.AdministratorInfos.Attach(administratorInfo);
				context.Entry(administratorInfo).Property(x => x.TimeStartSmena).IsModified = true;
				await context.SaveChangesAsync();
			}

			_log.Trace("Обновлена иформация об администраторе " + administratorInfo.ToString());
		}

		public async Task<List<AdministratorInfo>> GetCurrentAdministrator()
		{
			using (var context = ContextFactory.CreateDbContext(ConnectionString))
			{
				return await context.AdministratorInfos.ToListAsync();
			}
		}
	}
}
