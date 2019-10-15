using System.Data.Entity.ModelConfiguration;

namespace Anticafe.Model.Models.Mapping
{
    public class AdministratorInfoMap : EntityTypeConfiguration<AdministratorInfo>
    {
        public AdministratorInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AdministratorInfoes");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.NumberCard).HasColumnName("NumberCard");
            this.Property(t => t.SecondName).HasColumnName("SecondName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.BDay).HasColumnName("BDay");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Phone).HasColumnName("Phone");
        }
    }
}
