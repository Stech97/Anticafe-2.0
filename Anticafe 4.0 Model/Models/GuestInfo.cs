namespace Anticafe.Model.Models
{
    public partial class GuestInfo
    {
        public int ID { get; set; }
        public string NumberCard { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Discount { get; set; }
        public System.DateTime BDay { get; set; }
        public string Email { get; set; }
		public string Phone { get; set; }
		public  int? GuestID { get; set; }
		public Guest Guest { get; set; }

		public override string ToString() => SecondName + " " + FirstName + " " + MiddleName + " № кратры:" + NumberCard;
	}
}