using System.Linq;
using System.Data.Entity;
using Anticafe.Model.Models;
using System.Data.SqlClient;

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
				using (SqlConnection mSqlConnectionyConnection = new SqlConnection(ConnectionString))
				{
					var cs = mSqlConnectionyConnection.State;
					_log.Trace("Connection state: " + cs.ToString());
				}
				_log.Info("Connect to database correct");
				result = true;
			}
			catch (SqlException e)
			{
				_log.Fatal("Connect to database isn't open" + "\r\n" + "Ошибка:" + e.ToString());
				result = false;
			}
			catch (System.Data.Entity.Core.EntityException e)
			{
				_log.Errors("Connect to database isn't open" + "\r\n" + "Ошибка:" + e.ToString());
				result = false;
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

		/*public static string GetCurrentAdministrator()
		{
			using (TestContext _context = new TestContext())
			{
				var admin = _context.AdministratorInfoes.Where(c => c.
			}
		}*/
	}
}
