using System;
using System.Collections.Generic;

namespace Anticafe_4._0_Model.Models
{
    public partial class GuestInfo
    {
        public int ID { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Discount { get; set; }
        public System.DateTime BDay { get; set; }
        public string Email { get; set; }
    }
}
