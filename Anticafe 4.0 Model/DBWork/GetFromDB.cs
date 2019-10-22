using System.Linq;
using System.Windows;
using System.Data.Entity;
using Anticafe.Model.Models;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace Anticafe.Model
{
	public static class GetFromDB
	{
		private static readonly ILog _log = LogManager.CreateLogger("BackEnd", "trace");

		public static bool GetStateDB()
		{
			/* По хорошему от этого метода избавиться
             * или изменить для проверки БД по полной 
             * (разные типы БД)
             */

			const string ConnectionString = @"Data Source=MAX-PC\ANTICAFE_DB;Initial Catalog=Test;Integrated Security=True;MultipleActiveResultSets=True";
			bool result;

			try
			{
				using (SqlConnection sql = new SqlConnection(ConnectionString))
				{
					sql.Open();
					var cs = sql.State;
					_log.Trace("Состояние подключения:" + cs.ToString());
				}
				_log.Info("Подключение к Базе Данных осуществленно");
				result = true;
			}
			catch (SqlException exception)
			{
				_log.Fatal($"Ошибка в {nameof(Model)}. \r\nПричина: {exception.GetBaseException().Message}. \r\nСтек: {exception.StackTrace}.");
				result = false;

				MessageBox.Show("Нет подключения к Базе Данных \r\nПриложение будет остановленно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Stop, MessageBoxResult.OK);
			}
			catch (System.Data.Entity.Core.EntityException exception)
			{
				_log.Errors($"Ошибка в {nameof(Model)}. \r\nПричина: {exception.GetBaseException().Message}. \r\nСтек: {exception.StackTrace}.");
				result = false;

				MessageBox.Show("Нет подключения к Базе Данных \r\nПриложение будет остановленно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Stop, MessageBoxResult.OK);
			}

			return result;
		}

		public static System.ComponentModel.BindingList<GuestInfo> GetGuestInfo()
		{
			using (TestContext _context = new TestContext())
			{
				_context.GuestInfoes.Load();
				var result = _context.GuestInfoes.Local.ToBindingList();
				return result;
			}
		}

		public static System.ComponentModel.BindingList<AdministratorInfo> GetCurrentAdministrator()
		{
			using (TestContext _context = new TestContext())
			{
				_context.AdministratorInfoes.Load();
				var result = _context.AdministratorInfoes.Local.ToBindingList();
				return result;
			}
		}
	}
}
