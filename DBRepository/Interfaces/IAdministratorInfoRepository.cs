using Anticafe.Model;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace DBRepository.Interfaces
{
	public interface IAdministratorInfoRepository
	{
		Task SaveAdministratorInfo(AdministratorInfo administratorInfo);

		Task UpdateAdministratorInfoToDB(AdministratorInfo administratorInfo);

		Task<List<string>> GetCurrentAdministrator();
	}
}
