using Anticafe.Model;
using Microsoft.EntityFrameworkCore;

namespace DBRepository
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
		{

		}

		public DbSet<AdministratorInfo> AdministratorInfos { get; set; }
		public DbSet<Guest> Guests { get; set; }
		public DbSet<GuestInfo> GuestInfos { get; set; }
		public DbSet<Visit> Visits { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AdministratorInfo>().Property(u => u.Login).IsRequired();
			modelBuilder.Entity<AdministratorInfo>().Property(u => u.Password).IsRequired();
		}
	}
}