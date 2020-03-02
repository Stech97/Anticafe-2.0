using Anticafe.Model;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace DBRepository.Interfaces
{
	public interface IAdministratorInfoRepository
	{
		Task SaveAdministratorInfo(string login, string password, string numberCard, string firstName, string secondName, string middleName,
							 DateTime bday, string email, string phone);

		Task UpdateAdministratorInfoToDB(AdministratorInfo administratorInfo);

		Task<List<string>> GetCurrentAdministrator();
	}
}
