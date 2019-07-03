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
				// добавляем их в бд
				//db.GuestInfo.Add(user1);
				db.SaveChanges();

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

