using System;
using System.Data.Entity;
using Anticafe.Model.Models.Mapping;

namespace Anticafe.Model.Models
{
    public partial class TestContext : DbContext
    {
        static TestContext()
        {
            Database.SetInitializer<TestContext>(null);
        }

        public TestContext()
            : base("Name=TestContext")
        {
        }

        public DbSet<GuestInfo> GuestInfoes { get; set; }
        public DbSet<AdministratorInfo> AdministratorInfoes { get; set; }
        public DbSet<Errors> Errors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
                modelBuilder.Configurations.Add(new GuestInfoMap());
                modelBuilder.Configurations.Add(new AdministratorInfoMap());
                modelBuilder.Configurations.Add(new ErrorMap());
            }
        }
    }
}
