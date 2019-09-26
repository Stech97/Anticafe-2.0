using System;
using Anticafe_4._0_Model.Models;

namespace Anticafe_4._0_Model
{
    public static class SaveToDB
    {
        private static readonly TestContext _DB = new TestContext();

        public static void SaveGuestInfoToDB(string numberCard, string firstName, string secondName, string middleName,
            string discount, string bday, string email, string phone)
        {
            GuestInfo guestInfo = new GuestInfo
            {
                NumberCard = numberCard,
                FirstName = firstName,
                SecondName = secondName,
                MiddleName = middleName,
                Discount = int.Parse(discount),
                BDay = DateTime.Parse(bday),
                Email = email,
                Phone = phone
            };

            _DB.GuestInfoes.Add(guestInfo);
            _DB.SaveChanges();
            Logger.TraceLog("Добавлен новый гость " + guestInfo.ToString());
        }

        public static void SaveAdministratorInfoToDB(string login, string password, string numberCard, string firstName,
            string secondName, string middleName, string bday, string email, string phone)
        {
            AdministratorInfo administratorInfo = new AdministratorInfo
            {
                Login = login,
                Password = password,  // добавить шифрование
                NumberCard = numberCard,
                FirstName = firstName,
                SecondName = secondName,
                MiddleName = middleName,
                BDay = DateTime.Parse(bday),
                Email = email,
                Phone = phone
            };

            _DB.AdministratorInfoes.Add(administratorInfo);
            _DB.SaveChanges();
            Logger.TraceLog("У нас новый администратор:" + administratorInfo.ToString());
        }

        public static void SaveExeptionToDB(DateTime dateTime, string message)
        {
            Error exep = new Error
            {
                date = dateTime,
                Message = message
            };

            _DB.Errors.Add(exep);
            _DB.SaveChanges();       
        }

    }
}
