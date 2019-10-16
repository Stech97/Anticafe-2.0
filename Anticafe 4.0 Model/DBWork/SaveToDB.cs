using System;
using System.Globalization;
using Anticafe.Model.Models;

namespace Anticafe.Model
{
    public static class SaveToDB
    {
        private static readonly TestContext _DB = new TestContext();
        private static readonly Log _log = new Log();

        public static void SaveGuestInfoToDB(string numberCard, string firstName, string secondName, string middleName,
            string discount, string bday, string email, string phone)
        {
            GuestInfo guestInfo = new GuestInfo
            {
                NumberCard = numberCard,
                FirstName = firstName,
                SecondName = secondName,
                MiddleName = middleName,
                Discount = int.Parse(discount, NumberStyles.Integer, CultureInfo.InvariantCulture),
                BDay = DateTime.Parse(bday, CultureInfo.InvariantCulture),
                Email = email,
                Phone = phone
            };

            _DB.GuestInfoes.Add(guestInfo);
            _DB.SaveChanges();
            _log.Info("Добавлен новый гость " + guestInfo.ToString());
        }

        public static void SaveAdministratorInfoToDB(string login, string password, string numberCard, string firstName,
            string secondName, string middleName, string bday, IFormatProvider provider, string email, string phone)
        {
            AdministratorInfo administratorInfo = new AdministratorInfo
            {
                Login = login,
                Password = password,  // добавить шифрование
                NumberCard = numberCard,
                FirstName = firstName,
                SecondName = secondName,
                MiddleName = middleName,
                BDay = DateTime.Parse(bday, provider),
                Email = email,
                Phone = phone
            };

            _DB.AdministratorInfoes.Add(administratorInfo);
            _DB.SaveChanges();
            
        }

        public static void SaveExeptionToDB(DateTime dateTime, string message)
        {
            Errors exep = new Errors
            {
                date = dateTime,
                Message = message
            };

            _DB.Errors.Add(exep);
            _DB.SaveChanges();       
        }

    }
}
