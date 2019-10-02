using Anticafe_4._0_Model.Models;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Anticafe_4._0_Model
{
    public static class GetFromDB
    { 
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
                    Logger.TraceLog("Connection state: " + cs.ToString());
                }
                Logger.TraceLog("Connect to database correct");
                result = true;
            }
            catch (SqlException e)
            {
                Logger.ExeptionLog("Connect to database isn't open" + "\r\n" + "Ошибка:" + e.ToString());
                result = false;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                Logger.ExeptionLog("Connect to database isn't open" + "\r\n" + "Ошибка:" + e.ToString());
                result = false;
            }

            return result;
        }
        public static System.ComponentModel.BindingList<GuestInfo> GetGuestInfo()
        {
            TestContext _context = new TestContext();
            _context.GuestInfoes.Load();
            var result = _context.GuestInfoes.Local.ToBindingList();
            return result;
        }
    }
}
