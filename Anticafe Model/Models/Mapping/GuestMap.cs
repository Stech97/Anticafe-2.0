using System.Data.Entity.ModelConfiguration;

namespace Anticafe.Model.Models.Mapping
{
	class GuestMap : EntityTypeConfiguration<Guest>
	{
		public GuestMap()
		{
			// Primary Key
			HasKey(t => t.GuestID);

			// Properties
			// Table & Column Mappings
			ToTable("Guests");
			Property(t => t.GuestID).HasColumnName("ID");
			Property(t => t.LastInput).HasColumnName("Last_Input");
			Property(t => t.LastOutput).HasColumnName("Last_Output");
			Property(t => t.GuestInfoID).HasColumnName("GuestInfoID");
		}
	}
}
