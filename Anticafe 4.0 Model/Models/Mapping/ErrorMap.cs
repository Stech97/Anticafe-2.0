using System.Data.Entity.ModelConfiguration;

namespace Anticafe.Model.Models.Mapping
{
    public class ErrorMap : EntityTypeConfiguration<Errors>
    {
        public ErrorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Errors");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.date).HasColumnName("Date and time execption");
            this.Property(t => t.Message).HasColumnName("Message");

        }
    }
}
