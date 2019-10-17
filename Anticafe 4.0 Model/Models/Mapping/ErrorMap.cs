using System.Data.Entity.ModelConfiguration;

namespace Anticafe.Model.Models.Mapping
{
    public class ErrorMap : EntityTypeConfiguration<Errors>
    {
        public ErrorMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            ToTable("Errors");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.date).HasColumnName("Date and time execption");
            Property(t => t.Message).HasColumnName("Message");

        }
    }
}
