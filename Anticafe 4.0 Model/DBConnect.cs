using Anticafe_4._0_Model.Entity;

namespace Anticafe_4._0_Model
{
	public class DBConnect
	{
		GuestInfoContext db = new GuestInfoContext();

		public void AddGuestInfo(GuestInfo guestInfo)
		{
			//Добавление в БД
			db.GuestInfo.Add(guestInfo);
			db.SaveChanges();
		}

		/*public void GetGuestInfoById(int id)
		{
			var guestInfo = db.GuestInfo;
			return guestInfo;
		}*/
	}
}
