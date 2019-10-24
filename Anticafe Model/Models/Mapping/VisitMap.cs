using System.Data.Entity.ModelConfiguration;

namespace Anticafe.Model.Models.Mapping
{
	class VisitMap :  EntityTypeConfiguration<Visit>
	{
		public VisitMap()
		{
			// Primary Key
			HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			ToTable("Visits");
			Property(t => t.ID).HasColumnName("ID");
		}
	}
}
