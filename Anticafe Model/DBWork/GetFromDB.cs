using System;
using System.Windows;
using System.Data.Entity;
using Anticafe.Model.Models;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Anticafe.Model
{
	public static class GetFromDB
	{
		private static readonly ILog _log = LogManager.CreateLogger("BackEnd", "trace");

		public static void GetStateDB()
		{
			/* По хорошему от этого метода избавиться
             * или изменить для проверки БД по полной 
             * (разные типы БД)
             */

			//Data Source=MAX-PC\ANTICAFE_DB;Initial Catalog=AnticafeDB;User ID=sa;Password=!Qaz@Wsx
			//Data Source=MAX-PC\ANTICAFE_DB;Integrated Security=True;MultipleActiveResultSets=True

			const string ConnectionString = @"Data Source=MAX-PC\ANTICAFE_DB;Initial Catalog=AnticafeDB;Integrated Security=True;MultipleActiveResultSets=True";

			if (Database.Exists(ConnectionString))
			{
				using (SqlConnection sql = new SqlConnection(ConnectionString))
				{
					_log.Info("База данных " + sql.Database + " существует");
					sql.Open();
					_log.Trace("Состояние подключения:" + sql.State.ToString());
					sql.Close();
				}
			}

			else
			{
				using (SqlConnection sql = new SqlConnection(ConnectionString))
				{
					_log.Info("БД " + sql.Database + " не существует");
					_log.Trace("Создание таблиц");

					try
					{
						SaveToDB.SaveGuestToDB();
						SaveToDB.SaveGuestInfoToDB();
						SaveToDB.SaveAdministratorInfoToDB();
						SaveToDB.SaveExeptionToDB();
					}
					catch (Exception exp)
					{
						_log.Fatal($"Ошибка в {nameof(Model)}. \r\nПричина: {exp.GetBaseException().Message}. \r\nСтек: {exp.StackTrace}.");
						Environment.Exit(-1);
					}

					_log.Info("База данных " + sql.Database + " создана");
					sql.Open();
					_log.Trace("Состояние подключения:" + sql.State.ToString());
					sql.Close();
				}

			}

		}


		public static BindingList<GuestInfo> GetGuestInfo()
		{
			using (AnticafeDB _context = new AnticafeDB())
			{
				_context.GuestInfoes.Load();
				var result = _context.GuestInfoes.Local.ToBindingList();
				return result;
			}
		}

		public static BindingList<AdministratorInfo> GetCurrentAdministrator()
		{
			using (AnticafeDB _context = new AnticafeDB())
			{
				_context.AdministratorInfoes.Load();
				var result = _context.AdministratorInfoes.Local.ToBindingList();
				return result;
			}
		}
	}
}
