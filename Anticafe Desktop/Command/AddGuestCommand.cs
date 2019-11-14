using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Anticafe
{
	public class AddGuestCommand : RelayCommand
	{
		public AddGuestCommand(Action<object> execute, Func<object, bool> canExecute = null) : base(execute, canExecute) { }

		public override bool CanExecute(object parameter)
		{
			//Добавить проверку
			return false;
		}
		public override void Execute(object parameter)
		{
			//что исполнять
		}
	}
}
