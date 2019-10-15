using System;

namespace Anticafe.Model.Models
{
    public partial class AdministratorInfo
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string NumberCard { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BDay { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            string AdministratorInfoString;
            AdministratorInfoString = SecondName + " " + FirstName;
            return AdministratorInfoString;
        }
    }
}
