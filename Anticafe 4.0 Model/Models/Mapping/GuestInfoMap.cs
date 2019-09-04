using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Anticafe_4._0_Model.Models.Mapping
{
    public class GuestInfoMap : EntityTypeConfiguration<GuestInfo>
    {
        public GuestInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GuestInfoes");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SecondName).HasColumnName("SecondName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.BDay).HasColumnName("BDay");
            this.Property(t => t.Email).HasColumnName("Email");
			this.Property(t => t.Phone).HasColumnName("Phone");
		}
    }
}
