using System;
using System.Globalization;
using Anticafe.Model.Models;

namespace Anticafe.Model
{
    public static class SaveToDB
    {
        private static readonly AnticafeDB dB = new AnticafeDB();
		private static readonly ILog _log = LogManager.CreateLogger("BackEnd", "trace");

        public static void SaveGuestInfoToDB(string numberCard, string firstName, string secondName, string middleName,
												string discount, DateTime bday, string email, string phone)
        {
            GuestInfo guestInfo = new GuestInfo
            {
                NumberCard = numberCard,
                FirstName = firstName,
                SecondName = secondName,
                MiddleName = middleName,
                Discount = int.Parse(discount, NumberStyles.Integer, CultureInfo.InvariantCulture),
                BDay = bday,
                Email = email,
                Phone = phone
            };

            dB.GuestInfoes.Add(guestInfo);
            dB.SaveChanges();
            _log.Trace("Добавлен новый гость " + guestInfo.ToString());
        }

        public static void SaveAdministratorInfoToDB(string login, string password, string numberCard, string firstName, 
														string secondName, string middleName, DateTime bday, string email, string phone)
        {
            AdministratorInfo administratorInfo = new AdministratorInfo
            {
                Login = login,
                Password = password,  // добавить шифрование
                NumberCard = numberCard,
                FirstName = firstName,
                SecondName = secondName,
                MiddleName = middleName,
                BDay = bday,
                Email = email,
                Phone = phone
            };

            dB.AdministratorInfoes.Add(administratorInfo);
            dB.SaveChanges();
			_log.Trace("Добавлен новый администратор " + administratorInfo.ToString());
		}
        public static void AddRootAdministrator()
        {
            AdministratorInfo administratorInfo = new AdministratorInfo
            {
                Login = "admin",
                Password = "admin",
                NumberCard = "0",
                FirstName = "Администратор",
                SecondName = "Системы",
                MiddleName = " ",
                BDay = DateTime.Now.Date,
                Email = " ",
                Phone = " "

            };

            dB.AdministratorInfoes.Add(administratorInfo);
            dB.SaveChanges();
            _log.Trace("Добавлен рут-администратор " + administratorInfo.ToString());
        }
        /*public static void SaveExeptionToDB(DateTime dateTime, string message)
        {
			//сделать логирование через NLog
            Errors exep = new Errors
            {
                date = dateTime,
                Message = message
            };

            dB.Errors.Add(exep);
            dB.SaveChanges();
			_log.Trace("Добавлено исключение в БД");
		}*/

    }
}
