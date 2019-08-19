using System;
using System.ComponentModel.DataAnnotations;

namespace Anticafe_4._0_Model.Entity
{
	public class GuestInfo
	{
		public int ID { get; set; }

		public string SecondName { get; set; }

		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public int Discount { get; set; }

		public DateTime BDay { get; set; }

		public string Email { get; set; }

		//public string Phone { get; set; }

		//public byte[] Photo { get; set; }
	}
}
