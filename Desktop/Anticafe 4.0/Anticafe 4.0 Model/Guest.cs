using System;
using System.ComponentModel.DataAnnotations;

namespace Anticafe_4._0.Model
{
	public class Guest
	{
		public int ID { get; set; }
		[Required(ErrorMessage = "Фамилия гостя не установлена")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длина фамилии")]
		public string SecondName { get; set; }

		[Required(ErrorMessage = "Имя гостя не установлено")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		[Required(ErrorMessage = "Скидка гостю не установлена")]
		[Range (0,25, ErrorMessage = "Скидка гостю недопустима")]
		public int Discount { get; set; }

		[Required(ErrorMessage = "День рождения гостя не установлен")]
		public DateTime BDay { get; set; }

		[Required(ErrorMessage = "E-mail гостя не установлен")]
		[EmailAddress]
		public string Email { get; set;
		}
		[Required(ErrorMessage = "Номер телефона гостя не установлен")]
		[Phone]
		public string Phone { get; set; }

		public byte[] Photo { get; set; }

	}
}
