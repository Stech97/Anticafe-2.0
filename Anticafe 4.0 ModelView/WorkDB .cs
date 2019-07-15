using System;
using Anticafe_4._0.Model;

namespace Anticafe_4._0_ModelView
{
	public class WorkDB : IWorkDB
	{
		public string TestConnection()
		{
			return "OK";
		}

		public GuestInfo CreateGuestInfo(string secondName, string firstName,
									string middleName, string dis, string BD,
									string email, string phone, byte[] photo)
		{
			GuestInfo guestInfo = new GuestInfo
			{
				SecondName = secondName,
				FirstName = firstName,
				MiddleName = middleName,
				Discount = int.Parse(dis),
				BDay = Convert.ToDateTime(BD),
				Email = email,
				Phone = phone,
				Photo = photo
			};
			return guestInfo;
		}

	}
}