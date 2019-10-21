using System;

namespace Anticafe.Model.Models
{
	public partial class Guest
	{
		public int ID { get; set; }
		public string NumberCard { get; set; }
		public string SecondName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public int Discount { get; set; }
		public DateTime BDay { get; set; }

		public override string ToString() => SecondName + " " + FirstName + " " + MiddleName + " № кратры:" + NumberCard;
	}
}
