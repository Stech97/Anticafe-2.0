using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


//Создание сервиса для взаимодействия между View и Model
namespace Anticafe_4._0_Service
{
	[ServiceContract]
	public interface IWorkDB
	{
		[OperationContract]
		string TestConnection();

		//[OperationContract]
		//string 
	}


	[DataContract]
	public class CompositeType
	{
		public string TestConnection()
		{
			return "OK";
		}

	}
}
