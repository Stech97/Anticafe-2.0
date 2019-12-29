using System;
using System.Globalization;
using Anticafe.Model.Models;

namespace Anticafe.Model
{
    public static class SaveToDB
    {
        private static readonly AnticafeDB _DB = new AnticafeDB();
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

            _DB.GuestInfoes.Add(guestInfo);
            _DB.SaveChanges();
            _log.Trace("Добавлен новый гость " + guestInfo.ToString());
        }
        public static void SaveGuestInfoToDB()
        {
            GuestInfo guestInfo = new GuestInfo();
            _DB.GuestInfoes.Add(guestInfo);
            _DB.SaveChanges();
            _log.Info("Создана таблица GuestInfo");
        }

        public static void SaveGuestToDB()
        {
            Guest guest = new Guest();
            _DB.Guests.Add(guest);
            _DB.SaveChanges();
            _log.Info("Создана таблица Guest");
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

            _DB.AdministratorInfoes.Add(administratorInfo);
            _DB.SaveChanges();
			_log.Trace("Добавлен новый администратор " + administratorInfo.ToString());
		}
        public static void SaveAdministratorInfoToDB()
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

            _DB.AdministratorInfoes.Add(administratorInfo);
            _DB.SaveChanges();
            _log.Trace("Добавлена таблица AdministratorInfoes");
        }
        public static void SaveExeptionToDB(DateTime dateTime, string message)
        {
			//сделать логирование через NLog
            Errors exep = new Errors
            {
                date = dateTime,
                Message = message
            };

            _DB.Errors.Add(exep);
            _DB.SaveChanges();
			_log.Trace("Добавлено исключение в БД");
		}
        public static void SaveExeptionToDB()
        {
            //сделать логирование через NLog
            Errors exep = new Errors();

            _DB.Errors.Add(exep);
            _DB.SaveChanges();
            _log.Trace("Добавлена таблица Errors");
        }

    }
}
