using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace DBRepository.Interfaces
{
	public interface IGuestInfoRepository
	{
		Task SaveGuestInfo(
			string numberCard, string firstName, string secondName, string middleName,
			string discount, DateTime bday,	string email, string phone);

		Task<List<string>> GetGuestInfo();
	}
}
