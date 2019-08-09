using System;
using System.Collections.ObjectModel;

namespace Anticafe_4._0_Model
{
    public static class Administrator
    {
        public static string NameAdmin { get; set; }
        public static int StartSum { get; set; }
        public static DateTime StartTime { get; set; }
        public static ObservableCollection<Guest> ListGuest = new ObservableCollection<Guest>();
    }
}
