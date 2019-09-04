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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GuestInfoMap());
        }
    }
}
