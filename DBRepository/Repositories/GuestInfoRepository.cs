using Anticafe.Model;
using DBRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBRepository.Repositories
{
	public class GuestInfoRepository : BaseRepository, IGuestInfoRepository
	{
		private static readonly ILog _log = LogManager.CreateLogger("BackEnd", "trace");

		public GuestInfoRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

		public async Task<List<string>> GetGuestInfo()
		{
			using (var context = ContextFactory.CreateDbContext(ConnectionString))
			{
				return await context.GuestInfos.Select(x => x.ToString()).Distinct().ToListAsync();
			}
		}

		public async Task SaveGuestInfo(string numberCard, string firstName, string secondName, 
			string middleName, string discount, DateTime bday, string email, string phone)
		{
			GuestInfo guestInfo = new GuestInfo
			{
				NumberCard = numberCard,
				FirstName = firstName,
				SecondName = secondName,
				MiddleName = middleName,
				Discount = int.Parse(discount),
				BDay = bday,
				Email = email,
				Phone = phone
			};

			using (var context = ContextFactory.CreateDbContext(ConnectionString))
			{
				context.GuestInfos.Add(guestInfo);
				await context.SaveChangesAsync();
			}
			_log.Trace("Добавлен новый гость " + guestInfo.ToString());
		}
	}
}
