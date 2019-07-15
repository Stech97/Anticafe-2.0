using System.ServiceModel;
using Anticafe_4._0.Model;


//Создание сервиса для взаимодействия между View и Model
namespace Anticafe_4._0_ModelView
{
	[ServiceContract]
	public interface IWorkDB
	{
		[OperationContract]
		string TestConnection();

		[OperationContract]
		GuestInfo CreateGuestInfo(string secondName, string firstName, string middleName,
							string dis, string BD, string email, string phone, byte[] photo);
	}

}
