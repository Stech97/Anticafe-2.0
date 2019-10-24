using System;
using System.Collections.Generic;

namespace Anticafe.Model.Models
{
	public partial class Guest
	{
		public int ID { get; set; }
		public DateTime LastInput { get; set; }
		public DateTime LastOutput { get; set; }

		public ICollection<GuestInfo> GuestInfos { get; set; }

		public Guest()
		{
			GuestInfos = new List<GuestInfo>();
		}
	}	
}