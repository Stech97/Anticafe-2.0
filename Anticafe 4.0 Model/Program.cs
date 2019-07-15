using System;

namespace Anticafe_4._0.Model
{
	//Класс для взаимодействия с БД. 
	//TODO
	//Переработать под нужды GuestInfo с учётом сервиса
	class Program
	{
		static void Main(string[] args)
		{
			using (GuestContext db = new GuestContext())
			{
				// создаем два объекта Guest
				DateTime date1 = new DateTime(1996, 05, 10).Date;
				GuestInfo user1 = new GuestInfo {
					SecondName = "Иванов",
					FirstName = "Иван",
					MiddleName = "Петрович",
					Discount = 0,
					BDay =date1,
					Email ="ivan@ivanov.ru",
					Phone = "+79167458117",
					Photo = null};

				// добавляем их в бд
				db.GuestInfo.Add(user1);
				db.SaveChanges();
				Console.WriteLine("Объекты успешно сохранены");

				// получаем объекты из бд и выводим на консоль
				var guests = db.GuestInfo;
				Console.WriteLine("Список объектов:");
				foreach (GuestInfo g in guests)
				{
					Console.WriteLine($"{g.ID}.{g.SecondName} - {g.BDay}");
				}
			}
			Console.Read();
		}
	}
}

