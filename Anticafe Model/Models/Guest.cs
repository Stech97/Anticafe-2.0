using System;

namespace Anticafe.Model.Models
{
	public partial class Guest
	{
		public int GuestID { get; set; }
		public DateTime LastInput { get; set; }
		public DateTime LastOutput { get; set; }
		public int GuestInfoID { get; set; }
		public GuestInfo GuestInfo { get; set; }
	}	
}