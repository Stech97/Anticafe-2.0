using Microsoft.EntityFrameworkCore;

namespace Anticafe_4._0.Model
{
	//Класс для создания и работы с БД и таблицей GuestInfo
	public class GuestContext : DbContext
	{
		public DbSet<GuestInfo> GuestInfo { get; set; }

		public GuestContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=test;Trusted_Connection=True;");
		}
	}
}
