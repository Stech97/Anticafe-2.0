﻿using System.Data.Entity.ModelConfiguration;

namespace Anticafe.Model.Models.Mapping
{
	class GuestMap : EntityTypeConfiguration<Guest>
	{
		public GuestMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			ToTable("GuestInfoes");
			Property(t => t.ID).HasColumnName("ID");
			Property(t => t.LastInput).HasColumnName("Last_Input");
			Property(t => t.LastOutput).HasColumnName("Last_Output");
		}
	}
}
