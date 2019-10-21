using System.Data.Entity.ModelConfiguration;

namespace Anticafe.Model.Models.Mapping
{
    public class AdministratorInfoMap : EntityTypeConfiguration<AdministratorInfo>
    {
        public AdministratorInfoMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            ToTable("AdministratorInfoes");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.Login).HasColumnName("Login");
            Property(t => t.Password).HasColumnName("Password");
            Property(t => t.NumberCard).HasColumnName("NumberCard");
            Property(t => t.SecondName).HasColumnName("SecondName");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.MiddleName).HasColumnName("MiddleName");
            Property(t => t.BDay).HasColumnName("BDay");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Phone).HasColumnName("Phone");
        }
    }
}
