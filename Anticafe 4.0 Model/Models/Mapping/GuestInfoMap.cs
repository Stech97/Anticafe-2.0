using System.Data.Entity.ModelConfiguration;

namespace Anticafe.Model.Models.Mapping
{
    public class GuestInfoMap : EntityTypeConfiguration<GuestInfo>
    {
        public GuestInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            ToTable("GuestInfoes");
            Property(t => t.ID).HasColumnName("ID");
			Property(t => t.NumberCard).HasColumnName("NumberCard");
            Property(t => t.SecondName).HasColumnName("SecondName");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.MiddleName).HasColumnName("MiddleName");
            Property(t => t.Discount).HasColumnName("Discount");
            Property(t => t.BDay).HasColumnName("BDay");
            Property(t => t.Email).HasColumnName("Email");
			Property(t => t.Phone).HasColumnName("Phone");
		}
    }
}
