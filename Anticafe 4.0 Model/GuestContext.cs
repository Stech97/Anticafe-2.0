using System.Data.Entity;
using Anticafe_4._0_Model.Entity;

namespace Anticafe_4._0_Model
{
	public 	class GuestInfoContext : DbContext
    {
        public GuestInfoContext(): base("DbConnection") { }

		public DbSet<GuestInfo> GuestInfo { get; set; }
	}
}
