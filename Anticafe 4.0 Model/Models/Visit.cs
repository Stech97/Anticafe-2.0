using System;

namespace Anticafe.Model.Models
{
	public partial class Visit
	{
		public int ID { get; set; }
		public DateTime Input { get; set; }
		public DateTime Output { get; set; }

		//Guest info(p2p) 
		//Admin(p2p)
		//if Guuest out change fields in GuestTable
		//if Guest in set field in GuestTable
	}
}
