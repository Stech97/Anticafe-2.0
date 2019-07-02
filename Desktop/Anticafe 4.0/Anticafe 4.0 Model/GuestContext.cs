using Microsoft.EntityFrameworkCore;

namespace Anticafe_4._0.Model
{
	class GuestContext : DbContext
	{
		public DbSet<Guest> GuestInfo { get; set; }

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
