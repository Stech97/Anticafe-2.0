using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anticafe_4._0_Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			// Создадим клиент для обращения к службе.
			//var client = new DBService();

			// Вызовем метод службы и сохраним результат.
			//var result = client.

			return View();
		}

		public ActionResult About()
		{
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}