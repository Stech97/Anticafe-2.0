using System;

namespace Anticafe_4._0.Model
{
	class Program
	{
		static void Main(string[] args)
		{
			using (GuestContext db = new GuestContext())
			{
				// создаем два объекта Guest
				DateTime date1 = new DateTime(1996, 05, 10).Date;
				DateTime date2 = new DateTime(1998, 11, 26).Date;
				Guest user1 = new Guest {
					SecondName = "Иванов",
					FirstName = "Иван",
					MiddleName = "Петрович",
					Discount = 0,
					BDay =date1,
					Email ="ivan@ivanov.ru",
					Phone = "+79167458117",
					Photo = null};
				Guest user2 = new Guest {
					SecondName = "Петров",
					FirstName = "Степан",
					MiddleName = null,
					Discount = 5,
					BDay = date2,
					Email = "step@petr.ru",
					Phone = "+79167458118",
					Photo = null
				};

				// добавляем их в бд
				db.GuestInfo.Add(user1);
				db.GuestInfo.Add(user2);
				db.SaveChanges();
				Console.WriteLine("Объекты успешно сохранены");

				// получаем объекты из бд и выводим на консоль
				var guests = db.GuestInfo;
				Console.WriteLine("Список объектов:");
				foreach (Guest g in guests)
				{
					Console.WriteLine($"{g.ID}.{g.SecondName} - {g.BDay}");
				}
			}
			Console.Read();
		}
	}
}

