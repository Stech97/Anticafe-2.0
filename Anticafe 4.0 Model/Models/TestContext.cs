using System.Data.Entity;
using Anticafe_4._0_Model.Models.Mapping;

namespace Anticafe_4._0_Model.Models
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
        public DbSet<Error> Errors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GuestInfoMap());
            modelBuilder.Configurations.Add(new AdministratorInfoMap());
            modelBuilder.Configurations.Add(new ErrorMap());
        }
    }
}
