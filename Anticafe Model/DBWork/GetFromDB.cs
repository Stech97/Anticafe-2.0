using System.Collections.ObjectModel;
using System.Windows;
using System.Data.Entity;
using Anticafe.Model.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace Anticafe.Model
{
	public static class GetFromDB
	{
		private static readonly ILog _log = LogManager.CreateLogger("BackEnd", "trace");

		public static bool GetStateDB()
		{
			const string ConnectionStringMaster = @"Server=WS-Q0010\LOCALTEST;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True";
			ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

			bool result;

			try
			{
				using (SqlConnection sqlMaster = new SqlConnection(ConnectionStringMaster))
				{
					sqlMaster.Open();
					SqlCommand sqlCommand = new SqlCommand("SELECT * FROM sys.databases WHERE [name] = 'AnticafeDB'", sqlMaster);
					var answer = sqlCommand.ExecuteScalar();
					if (answer == null)
						SaveToDB.AddRootAdministrator();
				}
				
				using (SqlConnection sql = new SqlConnection(settings[0].ConnectionString))
				{
					sql.Open();
					var cs = sql.State;
					_log.Trace("Состояние подключения:" + cs.ToString());
				}

				_log.Info("Подключение к Базе Данных: " + settings[0].Name +" осуществленно");
				result = true;
			}
			catch (SqlException exception)
			{
				_log.Fatal($"Ошибка в {nameof(Model)}. \r\nПричина: {exception.GetBaseException().Message}. \r\nСтек: {exception.StackTrace}.");
				result = false;

				MessageBox.Show("Нет подключения к Базе Данных \r\nПриложение будет остановленно\r\n", 
								"Ошибка", MessageBoxButton.OK, MessageBoxImage.Stop, MessageBoxResult.OK);
			}
			catch (System.Data.Entity.Core.EntityException exception)
			{
				_log.Errors($"Ошибка в {nameof(Model)}. \r\nПричина: {exception.GetBaseException().Message}. \r\nСтек: {exception.StackTrace}.");
				result = false;
				

				MessageBox.Show("Нет подключения к Базе Данных \r\nПриложение будет остановленно \r\n"+"Причина: " + exception.GetBaseException().Message + ".", 
								"Ошибка", MessageBoxButton.OK, MessageBoxImage.Stop, MessageBoxResult.OK);
			}

			return result;
		}

		public static System.ComponentModel.BindingList<GuestInfo> GetGuestInfo()
		{
			using (AnticafeDB dB = new AnticafeDB())
			{
				dB.GuestInfoes.Load();
				var result = dB.GuestInfoes.Local.ToBindingList();
				return result;
			}
		}

		public static ObservableCollection<AdministratorInfo> GetCurrentAdministrator()
		{
			using (AnticafeDB dB = new AnticafeDB())
			{
				dB.AdministratorInfoes.Load();
				var result = dB.AdministratorInfoes.Local;
				return result;
			}
		}
	}
}
