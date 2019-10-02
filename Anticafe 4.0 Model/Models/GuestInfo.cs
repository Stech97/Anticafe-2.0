using System;

namespace Anticafe_4._0_Model.Models
{
    public partial class GuestInfo
    {
        public int ID { get; set; }
        public bool IsInside { get; set; }
        public string NumberCard { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Discount { get; set; }
        public DateTime BDay { get; set; }
        public string Email { get; set; }
		public string Phone { get; set; }

		public override string ToString()
		{
			string GuestInfoString;
			GuestInfoString = SecondName + " " + FirstName + " " + MiddleName + " № кратры:" + NumberCard;
			return GuestInfoString;
		}
	}
}
