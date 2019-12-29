using System.Data.Entity;
using Anticafe.Model.Models.Mapping;

namespace Anticafe.Model.Models
{
    public partial class AnticafeDB : DbContext
    {
		public AnticafeDB() : base("AnticafeDB") {}

		public DbSet<AdministratorInfo> AdministratorInfoes { get; set; }
		public DbSet<Errors> Errors { get; set; }
		public DbSet<Guest> Guests { get; set; }
		public DbSet<GuestInfo> GuestInfoes { get; set; }
		public DbSet<Visit> Visits { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
				modelBuilder.Entity<GuestInfo>().HasMany(c => c.Guests).WithRequired(o => o.GuestInfo);
				modelBuilder.Configurations.Add(new AdministratorInfoMap());
				modelBuilder.Configurations.Add(new GuestInfoMap());
				modelBuilder.Configurations.Add(new GuestMap());
				modelBuilder.Configurations.Add(new ErrorMap());
				modelBuilder.Configurations.Add(new VisitMap());
            }
        }
    }
}
